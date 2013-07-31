using System;

class BinaryDigits
{
    static void Main()
    {
        int bit = int.Parse(Console.ReadLine());
        int n= int.Parse(Console.ReadLine());
        long[] arr = new long[n];

        int bitsInNumber;
        for (int i = 0; i < n; i++)
        {
            arr[i] = long.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            bitsInNumber = 0;
            double m = Math.Log(arr[i],2);
            if(arr[i]==Math.Pow(2,m)&&bit==1)
            {
                m++;
            }
            for (int k = 0; k < m; k++)
            {
                long bitValue = (arr[i] >> k) & 1;

                if(bitValue==bit)
                {
                    bitsInNumber++;
                }
            }
            arr[i] = bitsInNumber;
        }
        foreach (int bits in arr)
        {
            Console.WriteLine(bits);
        }
    }
}