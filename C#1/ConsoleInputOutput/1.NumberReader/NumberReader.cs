using System;

class NumberReader
{
    static void Main()
    {
        Console.WriteLine("Enter First Number:");
        int a=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Third Number:");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("The Sum of the numbers is:"+(a+b+c));
    }
}

