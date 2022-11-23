// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.



// Example 1:

// Input: nums = [1,2,3,1]
// Output: true
// Example 2:

// Input: nums = [1,2,3,4]
// Output: false
// Example 3:

// Input: nums = [1,1,1,3,3,4,3,2,4,2]
// Output: true

public class Worker
{
    public static bool ContainsDuplicate(int[] nums)
    {
        ArrayGenerator.WatchDog.StartWatchDog();
        HashSet<int> set = new();
        bool containsDuplicate = false;
        foreach (int i in nums)
        {
            bool added = set.Add(i);
            if (added == false)
                containsDuplicate = true;
        }
        ArrayGenerator.WatchDog.StopWatchDog();

        return containsDuplicate;
    }
}