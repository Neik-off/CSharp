using System;

class TrapezoidsArea
{
    static void Main()
    {
        float area;
        Console.WriteLine("Enter a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b:");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter h:");
        int h = int.Parse(Console.ReadLine());

        area=(a+b)/2*h;
        Console.WriteLine("The area of your trapezoid is:"+area);
    }
}

