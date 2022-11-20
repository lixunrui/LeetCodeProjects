// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Hello, World!");

var prices = new int[] { 3, 3 };

var profit = Worker.MaxProfit(prices);

System.Console.WriteLine(profit);
if (profit == 0)
{
    System.Console.WriteLine("OK");
}
else
{
    System.Console.WriteLine("NO");
}
Console.ReadKey();