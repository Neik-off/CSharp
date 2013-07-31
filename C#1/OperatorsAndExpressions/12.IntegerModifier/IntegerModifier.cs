using System;

class IntegerModifier
{
    static void Main()
    {
        Console.WriteLine("Enter your Integer:");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Bit's position(starting from 0):");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Bit's Value(1 or 0):");
        int v = int.Parse(Console.ReadLine());

        if(v==1)
        {
            int mask = 1;
            i = i|(mask << p);
        }
        else
        {
            int mask = 1;
            int invertedMask = ~(mask<<p);
            i = i & invertedMask;
        }
        Console.WriteLine("The result is: "+i);

    }
}
