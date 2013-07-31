using System;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Enter Integer:");
        UInt32 n = UInt32.Parse(Console.ReadLine());
        Console.WriteLine("The binary number is:" + Convert.ToString(n, 2));
        UInt32 resultInt = n; 

        for (int i = 3,v=24; i < 6; i++,v++ )
        {
            UInt32 mask = 1;
            mask = mask << i;
            UInt32 nAndMask = (n & mask);
            UInt32 BitValue = nAndMask >> i;

            if (BitValue == 1)
            {
                mask = 1;
                resultInt = resultInt | (mask << v);
            }
            else
            {
                mask = 1;
                UInt32 invertedMask = ~(mask << v);
                resultInt = resultInt & invertedMask;
            }

            mask = 1;
            mask = mask << v;
            UInt32 vAndMask = (n & mask);
            BitValue = vAndMask >> v;

            if (BitValue == 1)
            {
                mask = 1;
                resultInt = resultInt | (mask << i);
            }
            else
            {
                mask = 1;
                UInt32 invertedMask = ~(mask << i);
                resultInt = resultInt & invertedMask;
            }
        }

        Console.WriteLine("The Binary result is:" + Convert.ToString(resultInt, 2));
        Console.WriteLine("The decimal result is:" + resultInt);
    }
}

