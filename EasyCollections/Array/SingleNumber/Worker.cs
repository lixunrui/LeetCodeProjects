public class Worker
{
    public static int SingleNumber(int[] nums)
    {
        int result = 0;
        ArrayGenerator.WatchDog.StartWatchDog();
        HashSet<int> collection = new HashSet<int>();
        foreach (var i in nums)
        {
            if (!collection.Add(i))
            {
                collection.Remove(i);
            }

        }

        if (collection.Count == 1)
        {
            result = collection.ElementAt(0);
        }

        ArrayGenerator.WatchDog.StopWatchDog();
        return result;
    }
}