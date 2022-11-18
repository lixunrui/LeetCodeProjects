// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] nums = new int[] { 1, 1, 2, 3, 3, 4, 5 };

int[] expectedNums = new int[] { 1, 2 };

int k = Worker.RemoveDuplicate(nums);

if (k != expectedNums.Length)
{
    Console.WriteLine("NO 1");
}

for (int i = 0; i < k; i++)
{
    if (nums[i] != expectedNums[i])
    {
        System.Console.WriteLine("No 2");
    }
}

System.Console.WriteLine("Pass");
