// See https://aka.ms/new-console-template for more information
using ArrayGenerator;

Console.WriteLine("Hello, World!");

var array = ArrayGenerator.ArrayGenerator.GenerateArray(1000000, -100000, 100000, true);

if (Worker.ContainsDuplicate(array))
{
    System.Console.WriteLine("Container duplicates");
}
else
{
    System.Console.WriteLine("Not");
}


Console.WriteLine("Done");