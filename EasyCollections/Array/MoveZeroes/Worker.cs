public static class Worker
{
    public static int[] MoveZeroes(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length - 1; j++)
            {
                if (nums[j] == 0)
                {
                    nums[j] = nums[j+1];
                    nums[j+1] = 0;
                    
                }
            }
        }

        return nums;
    }
}