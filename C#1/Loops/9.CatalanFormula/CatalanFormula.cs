using System;

class CatalanFormula
{
    static void Main()
    {

        int i=5;
        Console.WriteLine("The Catalan Number is:"+Catalan(i));

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