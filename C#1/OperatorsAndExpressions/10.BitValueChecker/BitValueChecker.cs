using System;

class BitValueChecker
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your Integer:");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Bit's position(starting from 0):");
        int p = int.Parse(Console.ReadLine());

        int mask=1;
        mask= mask << p;
        bool result;
        int vAndMask=(v & mask);
        result = ((vAndMask>>p)==1);

        Console.WriteLine("The bit's value is 1?" + result);
        
    }
}
