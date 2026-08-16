using System;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> seen = new Dictionary<int, int>(); //a dictionary that will contain numbers and their indexes
        for (int i = 0; i < nums.Length; i++)
        {
            int n = nums[i]; //assign current number to n
            if (seen.ContainsKey(target - n))
            { //check if there is the value that will create target value 
                return new int[] { seen[target - n], i }; //return result
            }
            seen[n] = i; //add current number to dictionary
        }
        return null;
    }
}

class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        //Case 1:
        int[] nums1 = { 2, 7, 11, 15 };
        int target1 = 9;
        int[] result1 = solution.TwoSum(nums1, target1);
        Console.WriteLine("Result for case 1: [" + result1[0] + "," + result1[1] + "]");

        //Case 2:
        int[] nums2 = { 3, 2, 4 };
        int target2 = 6;
        int[] result2 = solution.TwoSum(nums2, target2);
        Console.WriteLine("Result for case 2: [" + result2[0] + "," + result2[1] + "]");

        //Case 3:
        int[] nums3 = { 3, 3 };
        int target3 = 6;
        int[] result3 = solution.TwoSum(nums3, target3);
        Console.WriteLine("Result for case 3: [" + result3[0] + "," + result3[1] + "]");
    }
}
