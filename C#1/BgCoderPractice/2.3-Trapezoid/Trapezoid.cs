using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char symbol = '.';
        for (int i = 0; i <= n; i++)
        {
            for (int k = 0; k < 2*n; k++)
            {
                if(i==0&&k>=n)
                {
                    symbol = '*';
                }
                else if (i == n||k==2*n-1)
                {
                    symbol = '*';
                }
                else if (k==n-i)
                {
                    symbol = '*';
                }
                else 
                {
                    symbol = '.';
                }
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
        
    }
}