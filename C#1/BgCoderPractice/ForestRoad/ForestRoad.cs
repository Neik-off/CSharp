using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter=n-2;
        char symbol;

        for (int i = 0; i < (2*n)-1; i++)
        {
            if(i>n)
            {
            counter--;
            }
            for (int k = 0; k < n; k++)
            {
                if(k==i)
                {
                    symbol = '*';
                }
                else if(i>=n && k==counter)
                {
                    symbol = '*';
                }
                else
                {
                    symbol = '.';
                }
                Console.Write(symbol);
                if(k == n-1)
                {
                    Console.WriteLine();
                }
            }
        }

    }
}
