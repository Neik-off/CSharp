using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter the a number:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the b number:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the c number:");
        double c = double.Parse(Console.ReadLine());

        double firstRoot, secondRoot;
        double D;
        D = (b * b) - (4 * a * c);
        Console.WriteLine("The discriminant is:"+D);
        if(D==0)
        {
            firstRoot = ((-b) + Math.Sqrt(D)) / 2 * a;
            secondRoot = firstRoot;
            Console.WriteLine("The roots are equal:{0} and {1}", firstRoot, secondRoot);
        }
        else if(D<0)
        {
            Console.WriteLine("There are no real Roots!");
        }
        else
        {
            firstRoot = ((-b) + Math.Sqrt(D) )/ 2 * a;
            secondRoot = ((-b) - Math.Sqrt(D)) / 2 * a;
            Console.WriteLine("The roots are:{0} and {1}", firstRoot, secondRoot);
        }
        
    }
}
