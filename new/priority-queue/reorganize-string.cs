// Pattern: Priority queue (min-heap)
// When to use:
// Complexity:

public class Solution {
    public string ReorganizeString(string s) {
        if(s == null) {
            return "";
        }

        string result = "";
        char prev = '\0';
        Dictionary<char, int> frequency = new Dictionary<char, int>();

        foreach(char c in s) {
            if(!frequency.ContainsKey(c)) {
                frequency[c] = 0;
            }
            frequency[c]++;
        }

        PriorityQueue<char, int> queue = new PriorityQueue<char, int>();
        foreach(var letter in frequency) {
            queue.Enqueue(letter.Key, -letter.Value);
        }

        while(queue.Count > 0) {
            char letter = queue.Dequeue();
            if(letter == prev) {
                if(queue.Count == 0)
                {
                    return "";
                }

                char next = queue.Dequeue();
                result += next;
                frequency[next]--;
                if(frequency[next] > 0) {
                    queue.Enqueue(next, -frequency[next]);
                }
                if(frequency[letter] > 0) {
                    queue.Enqueue(letter, -frequency[letter]);
                }
                prev = next;
            }
            else {
                result += letter;
                frequency[letter]--;
                if(frequency[letter] > 0) {
                    queue.Enqueue(letter, -frequency[letter]);
                }
                prev = letter;
            }
        }

        return result;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        var result1 = solution.ReorganizeString("aab");
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.ReorganizeString("aaab");
        Console.WriteLine("Result for case 2: " + result2);
    }
}