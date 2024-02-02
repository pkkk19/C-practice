// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");
using System;
using System.Collections.Generic;
using System.IO;
class Solution
{

    static int solveMeFirst(int a, int b)
    {
        return a + b;

    }

    static void Main(String[] args)
    {
        int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        int sum = solveMeFirst(val1, val2);
        Console.WriteLine(sum);
    }
}