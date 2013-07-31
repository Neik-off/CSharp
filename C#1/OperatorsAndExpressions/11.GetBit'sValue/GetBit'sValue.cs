using System;

class GetBitsValue
{
    static void Main()
    {
        Console.WriteLine("Enter your Integer:");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Bit's position(starting from 0):");
        int p = int.Parse(Console.ReadLine());

        int mask = 1;
        mask = mask << p;
        int vAndMask = (i & mask);
        int bitValue= vAndMask >> p;

        Console.WriteLine("The bit's value is:" + bitValue);
    }
}
