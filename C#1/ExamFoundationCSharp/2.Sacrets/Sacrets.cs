using System;
using System.Numerics;

class Sacrets
{
    static void Main()
    {
        BigInteger N = BigInteger.Parse(Console.ReadLine());
        BigInteger number = N;
        BigInteger specialSum = 0;
        int divider = 10;

        if (N < 0)
        {
            N = -N;
        }

        for (int i = 1; i <= 400; i++)
        {
            if (i % 2 != 0)
            {
                specialSum = BigInteger.Add(specialSum, (BigInteger.Multiply(BigInteger.Remainder(N, 10), (int)Math.Pow(i, 2))));
                N = BigInteger.Divide(N, divider);
            }
            else
            {
                specialSum = BigInteger.Add(specialSum, (BigInteger.Multiply(BigInteger.Pow(BigInteger.Remainder(N, 10), 2), i)));
                N = BigInteger.Divide(N, divider);
            }
        }
        BigInteger seqLenght = BigInteger.Remainder(specialSum, 10);
        BigInteger R = BigInteger.Remainder(specialSum, 26);
        BigInteger firstLetter = BigInteger.Add(R, 1);
        char letter;
        Console.WriteLine(specialSum);
        if (seqLenght == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", number);
        }
        else
        {
            for (BigInteger i = 0, j = BigInteger.Add(64, firstLetter); i < seqLenght; i++, j++)
            {
                letter = (char)j;
                Console.Write(letter);
                if (j == 90)
                {
                    j = 64;
                }
            }
            Console.WriteLine();
        }
    }
}