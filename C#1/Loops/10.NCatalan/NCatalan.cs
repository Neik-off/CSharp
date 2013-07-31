using System;

class NCatalan
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Catalan Number u want:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The Catalan Number is:" + Catalan(n));

    }

    public static long Catalan(int n)
    {
        long result = Factorial(2 * n) / Factorial(n + 1) * Factorial(n);
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

