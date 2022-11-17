public class Worker
{
    public static int RemoveDuplicate(int[] nums)
    {
        int count = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1]) count++;
            else nums[i - count] = nums[i];
        }
        return nums.Length - count;

    }
}




