public class Worker
{
    public static int[] PlusOne(int[] digits)
    {
        ArrayGenerator.WatchDog.StartWatchDog();
        double number = 0;


        //Array.Reverse(digits);

        for (int i = 0; i < digits.Length; i++)
        {
            number *= Math.Pow(10, i > 0 ? 1 : 0);
            number += digits[i];
        }

        number++;
        List<int> newNumber = new List<int>();
        for (; number != 0; number /= 10)
        {
            newNumber.Add((int)(number % 10));
            number -= number % 10;
        }


        newNumber.Reverse();
        ArrayGenerator.WatchDog.StopWatchDog();

        return newNumber.ToArray();

        // Array.Resize(ref digits, digits.Length+1);

        // int curIndex = digits.Length - 1;
        // var digit = digits[curIndex];

        // while(digit == 9 && curIndex >=0)
        // {
        //     digits[curIndex] = 0 ;
        //     curIndex--;
        //     digit = digits[curIndex]+1;
        // }


        // Array.Reverse(digits);




        // return digits;
    }
}