using System;

class BitsRotate
{
    static void Main()
    {
        Console.WriteLine("Enter Your Integer:");
        UInt32 n = UInt32.Parse(Console.ReadLine());
        UInt32 resultInt = 0;

        Console.WriteLine("The Binary result is:" + Convert.ToString(n, 2));

        for(int p=0,v=31;p<32;p++,v--)
        {
            UInt32 mask = 1;
            mask = mask << p;
            UInt32 vAndMask = (n & mask);
            UInt32 BitValue = vAndMask >> p;

            if(BitValue==1)
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
        }
        Console.WriteLine("The result Integer is:"+resultInt);
        Console.WriteLine("The Binary result is:" + Convert.ToString(resultInt, 2));



    }
}