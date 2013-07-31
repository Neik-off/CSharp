using System;

class BitChecker
{
    static void Main()
    {
        while (true)
        {
            bool result;
            int mask = 1 << 2;

            Console.WriteLine("Enter Integer:");
            int userNumber = int.Parse(Console.ReadLine());
            
            result = ((userNumber & mask) >> 2) == 0;

            if (result)
            {
                Console.WriteLine("The bit is 0!");
            }
            else
            {
                Console.WriteLine("The bit is 1!");
            }
        }
    }
}

