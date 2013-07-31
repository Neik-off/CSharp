using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter a Number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b Number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter c Number:");
        int c = int.Parse(Console.ReadLine());

        double x1=0, x2=0;
        int D=(b*b)-(4*a*c);
        Console.WriteLine("The Discriminant is:"+D);

        double sqrtD=Math.Sqrt(D);

        if(D>0)
        {
            x1 = (-b + sqrtD) / (2 * a);
            x2 = (-b - sqrtD) / (2 * a);
            Console.WriteLine("The roots are {0} and {1}", x1, x2);
        }
        else if (D == 0)
        {
            x1 = (-b + sqrtD) / (2 * a);
            x2 = x1;
            Console.WriteLine("The roots are equal x1=x2={0}", x1);
        }
        else
        {
            Console.WriteLine("There are no real roots");
        }
        
    }
}
