using System;

class HelloMethod
{
    static void Main()
    {
        PrintName();
    }
    static void PrintName()
    {
        Console.WriteLine("Please Enter Your Name:");
        string name = Console.ReadLine();
        Console.WriteLine(name);
    }
}