using System;

class OddOrEvenChecker
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter number you want to check:");
            int theNumber = int.Parse(Console.ReadLine());
            if (theNumber % 2 == 0)
            {
                Console.WriteLine("The Number is even!");
            }
            else
            {
                Console.WriteLine("The Number is odd");
            }
        }
    }
}

