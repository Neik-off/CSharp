using System;

class CircleAreaCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter Circle's Radius:");
        int r = int.Parse(Console.ReadLine());
        Console.WriteLine("The Circle's Perimeter is:" + (2 * r * Math.PI));
        Console.WriteLine("The Circle's Area is:"+(r*r*Math.PI));
    }
}
