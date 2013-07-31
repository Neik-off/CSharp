using System;

class FactorialsDividing
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculating N!/K!" + "\n(1<K<N)" + "\nEnter N:");
            int n = int.Parse(Console.ReadLine());
            if(n<1)
            {
                Console.WriteLine("Out of Interval");
                continue;
            }
            Console.WriteLine("Enter K");
            int k = int.Parse(Console.ReadLine());
            if (k<1||k>n)
            {
                Console.WriteLine("Wrong number!");
                continue;
            }
            Console.WriteLine("The result from the calculation is: "+Factorial(n) / Factorial(k));
            Console.WriteLine("=========================================================");
        }
    }
    public static long Factorial(int number)
    {
        long result=0;
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
