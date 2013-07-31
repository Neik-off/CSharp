using System;

class TrailingZeros
{
    static void Main()
    {
        int n = 19;
        Console.WriteLine("The trailing zeros are:"+Factorial(n));
    }
    public static int Factorial(int number)
    {
        long result = 0;
        int zeroes = 0;
        for (int i = 1; i <= number; i++)
        {
            if (i == 1)
            {
                result = 1;
            }
            else
            {
                result *= i;
            }
            if(i==5||i%5==0)
            {
                zeroes++;
            }
        }
        Console.WriteLine(result);
        return zeroes;
    }
}