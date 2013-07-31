using System;

class SumCalculation
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter X:");
        int x = int.Parse(Console.ReadLine());

        double sum = 1.0;
        for (int i = 1; i <= n;  i++)
        {
            sum += ((double)Factorial(i) / (double)Power(x, i));
        }
        Console.WriteLine("The result is: " + sum);
        
    }

    public static long Power(int number,int power)
    {
        long result=1;
        int count=1;
        while(count<=power)
        {
            result *= number;
            count++;
        }
        return result;
    }

    public static long Factorial(int number)
    {
        long result = 0;
        for (int i = 0; i <= number; i++)
        {
            if (i == 0 || i == 1)
            {
                result = 1;
            }
            else
            {
                result *= i;
            }
        }
        return result;
    }
}