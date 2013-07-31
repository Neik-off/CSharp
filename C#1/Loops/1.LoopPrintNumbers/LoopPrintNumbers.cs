using System;

class LoopPrintNumbers
{
    static void Main()
    {
        int i = 1, n = 20;

        Console.Write("The sequence:{");
        while(i<=n)
        {
            Console.Write(i+" ");
            i++;
        }
        Console.WriteLine("}");
    }
}