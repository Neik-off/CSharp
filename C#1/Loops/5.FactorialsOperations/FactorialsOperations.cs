using System;

class FactorialsOperations
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculating N!*K!/(K-N)!" + "\n(1<N<K)" + "\nEnter K:");
            int k = int.Parse(Console.ReadLine());
            if (k < 1)
            {
                Console.WriteLine("Out of Interval");
                continue;
            }
            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > k)
            {
                Console.WriteLine("Wrong number!");
                continue;
            }
            Console.WriteLine("The result from the calculation is: " + ((Factorial(n) * Factorial(k))/Factorial(k-n)));
            Console.WriteLine("=========================================================");
        }

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
