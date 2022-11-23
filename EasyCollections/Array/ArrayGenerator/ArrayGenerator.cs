
namespace ArrayGenerator;
public class ArrayGenerator
{
    public static int[] GenerateArray(long length, int minValue, int maxValue, bool duplicates = false)
    {
        Random random = new Random();
        List<int> collection = new List<int>();
        for (int i = 0; i < length; i++)
        {
            var value = random.Next(minValue, maxValue);
            if (duplicates)
            {
                if (value % 2 == 0)
                {
                    // add a duplicate
                    collection.Add(value);
                    i++;
                }
            }
            collection.Add(value);
        }

        return collection.ToArray();

    }
}


public class WatchDog
{
    private static Stopwatch timer = new Stopwatch();

    public static void StartWatchDog()
    {
        timer = new Stopwatch();
        timer.Start();
    }

    public static void StopWatchDog()
    {
        if (timer != null)
        {
            timer.Stop();
            System.Console.WriteLine(timer.ElapsedMilliseconds.ToString());
        }
        else
        {
            System.Console.WriteLine("Timer not started");
        }
    }
}