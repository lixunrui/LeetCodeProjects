/*
Given an array, rotate the array to the right by k steps, where k is non-negative.

 

Example 1:

Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]
Example 2:

Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]

*/

public class Worker
{
    public static void Rotate(int[] nums, int k)
    {
        //AdditionalArray(nums, k);
        ReverseArray(nums, k);
    }

    // more memory
    // fast speed
    private static void ReverseArray(int[] nums, int k)
    {
        while (k >= nums.Length)
        {
            k -= nums.Length;
        }

        if (k == 0)
            return;

        int length = nums.Length;
        Array.Reverse(nums, 0, length - k);
        Array.Reverse(nums, length - k, k);
        Array.Reverse(nums);
    }

    // less memory
    // slow speed
    private static void AdditionalArray(int[] nums, int k)
    {

        while (k >= nums.Length)
        {
            k -= nums.Length;
        }

        if (k == 0)
            return;

        int length = nums.Length;

        int[] newNums = new int[length];
        nums.CopyTo(newNums, 0);

        for (int i = 0; i < length; i++)
        {
            int index = k + i;
            if (index >= length)
            {
                index -= length;
            }
            nums[index] = newNums[i];

        }




    }
}
