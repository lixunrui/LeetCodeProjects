public class Worker
{
    public static int[] Intersect(int[] nums1, int[] nums2)
    {

        ArrayGenerator.WatchDog.StartWatchDog();

        var dic1 = new Dictionary<int, int>();
        foreach (var num in nums1)
        {
            if (dic1.ContainsKey(num))
                dic1[num]++;
            else
                dic1[num] = 1;
        }

        List<int> results = new List<int>();

        foreach (int num in nums2)
        {
            if (dic1.ContainsKey(num) && dic1[num] > 0)
            {
                results.Add(num);
                dic1[num]--;
            }

        }

        ArrayGenerator.WatchDog.StopWatchDog();

        return results.ToArray();
    }
}