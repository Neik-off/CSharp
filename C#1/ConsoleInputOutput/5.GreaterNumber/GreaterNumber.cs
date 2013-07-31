using System;

class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter First Number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("============================");
        Console.WriteLine("A Greater then B?" +(a > b));
        Console.WriteLine("============================");
        Console.WriteLine("B Greater then A?" + (a < b));
        Console.WriteLine("============================");
        Console.WriteLine("A Equal B?" + (a == b));
        Console.WriteLine("============================");
    }
}
