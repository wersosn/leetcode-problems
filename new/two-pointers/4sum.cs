// Pattern: Sorting + two pointers (fix two elements, then search for the remaining pair)
// When to use: Finding unique quadruplets that satisfy a target sum in an array
// Complexity: O(n^3) time and O(k) space for the result (excluding sorting; k is the number of quadruplets)

public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        var result = new List<IList<int>>();

        for(int i = 0; i < nums.Length; i++) {
            if(i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }

            for(int j = i + 1; j < nums.Length - 2; j++) {
                if(j > i + 1 && nums[j] == nums[j - 1]) {
                    continue;
                }
                
                int left = j + 1;
                int right = nums.Length - 1;
                while(left < right) {
                    long sum = (long)nums[i] + (long)nums[j] + (long)nums[left] + (long)nums[right];
                    if(sum == target) {
                        result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                        
                        left++;
                        right--;

                        while(left < right && nums[left] == nums[left - 1]) {
                            left++;
                        }

                        while(left < right && nums[right] == nums[right + 1]) {
                            right--;
                        }
                    }
                    else if(sum < target) {
                        left++;
                    }
                    else {
                        right--;
                    }
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
        var result1 = solution.FourSum([1,0,-1,0,-2,2], 0);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.FourSum([2,2,2,2,2], 8);
        Console.WriteLine("Result for case 2: " + result2);
    }
}