// 1.
// Pattern: Hash map frequency counting
// When to use: When you need occurrence counts to identify the most frequent element
// Complexity: O(n) time and O(n) space
public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> majority = new Dictionary<int, int>();
        foreach(int num in nums) {
            if(!majority.ContainsKey(num)) {
                majority[num] = 0;
            }
            majority[num]++;
        }
        return majority.OrderByDescending(x => x.Value).First().Key;
    }
}

// 2.
// Pattern: Boyer-Moore voting algorithm
// When to use: When the input guarantees an element appears more than n / 2 times
// Complexity: O(n) time and O(1) space
public class Solution {
    public int MajorityElementBM(int[] nums) {
        int candidate = 0, count = 0;
        foreach(int num in nums) {
            if(count == 0) {
                candidate = num;
            }

            if(num == candidate) {
                count++;
            }
            else {
                count--;
            }
        }
        return candidate;
    }
}

// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        //Case 1:
        bool result1 = solution.MajorityElement([3,2,3]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        bool result2 = solution.MajorityElement([2,2,1,1,1,2,2]);
        Console.WriteLine("Result for case 2: " + result2);
    }
}
