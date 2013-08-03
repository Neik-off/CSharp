using System;

class CharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter length for the array's:");
        int length = int.Parse(Console.ReadLine());
        char[] firstSequence=new char[length];
        char[] secondSequence = new char[length];

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Enter char for the first array:");
            firstSequence[i] = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter char for the second array:");
            firstSequence[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < length; i++)
        {
            if(firstSequence[i] > secondSequence[i])
            {
                Console.WriteLine("The bigger char in for index({0}) is in the first Char array!",i);
            }
            else if (secondSequence[i] > firstSequence[i])
            {
                Console.WriteLine("The bigger char in for index({0}) is in the second Char array!", i);
            }
            else
            {
                Console.WriteLine("The char's for index({0}) are the same!",i);
            }

        }
    }
}