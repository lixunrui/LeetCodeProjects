// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] nums = new int[]{1,2,3,4,5,6,7};
int k = 3;
int[] expectedNums = new int[]{5,6,7,1,2,3,4};

Worker.Rotate(nums, k);

if(nums.Length != expectedNums.Length)
    throw new Exception();

for(int i = 0;i< nums.Length; i ++)
{
    if(nums[i] != expectedNums[i])
        throw new Exception();
}


System.Console.WriteLine("Results");