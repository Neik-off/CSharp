using System;

class Deviding5And7
{
    static void Main()
    {
        while (true)
        {
            bool result;
            //The user choice
            Console.WriteLine("Enter number for test:");
            int checkedNumber = int.Parse(Console.ReadLine());
            //The test for dividing
            if (result = (checkedNumber % 5 == 0 && checkedNumber % 7 == 0))
            {
                Console.WriteLine("The number can be divided!");
            }
            else
            {
                Console.WriteLine("The number cannot divided!");
            }
        }
    }
}

