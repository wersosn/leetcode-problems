// Pattern: Sort the array, fix one element, then use two pointers to find the remaining pair.
// When to use: Finding unique triplets (or pairs) that satisfy a target sum in an array.
// Complexity: O(n²) time and O(1) auxiliary space, excluding the space used by the result.

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var result = new List<IList<int>>();

        for(int i = 0; i < nums.Length; i++) 
        {
            if(i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            int left = i + 1;
            int right = nums.Length - 1;
            while(left < right) {
                int sum = nums[i] + nums[left] + nums[right];
                if(sum == 0) {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    
                    left++;
                    right--;

                    while(left < right && nums[left] == nums[left - 1])
                    {
                        left++;
                    }

                    while(left < right && nums[right] == nums[right + 1])
                    {
                        right--;
                    }
                }
                else if(sum < 0) {
                    left++;
                }
                else {
                    right--;
                }
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
        var result1 = solution.ThreeSum([-1,0,1,2,-1,-4]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.ThreeSum([0,1,1]);
        Console.WriteLine("Result for case 2: " + result2);

        //Case 3:
        var result3 = solution.ThreeSum([0,0,0]);
        Console.WriteLine("Result for case 3: " + result3);
    }
}