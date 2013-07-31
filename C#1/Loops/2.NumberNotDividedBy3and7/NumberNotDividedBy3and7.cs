using System;

class NumberNotDividedBy3and7
{
    static void Main()
    {
        int i=1, n = 100;
        Console.WriteLine("The numbers divided by 3 and 7 (at the same time) are:");
        Console.Write("{");
        while (i <= n)
        {
            if (i % 3 == 0 && i % 7 == 0)
            {
                Console.Write(i + " ");
            }
            i++;
        }
        Console.WriteLine("}");
    }
}
