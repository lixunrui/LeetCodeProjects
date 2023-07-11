public class Worker
{
    public static int[] PlusOne(int[] digits)
    {
        ArrayGenerator.WatchDog.StartWatchDog();
        for (int i = digits.Length - 1; i >= -1; i--)
        {
            if (i == -1)
            {
                var newDigits = new int[digits.Length + 1];
                newDigits[0] = 1;
                Array.Copy(digits, 0, newDigits, 1, digits.Length);
                ArrayGenerator.WatchDog.StopWatchDog();
                return newDigits;
            }

            if (digits[i] < 9)
            {
                digits[i] += 1;
                break;
            }
            else
            {
                digits[i] = 0;
            }

        }
        ArrayGenerator.WatchDog.StopWatchDog();
        return digits;
    }
}