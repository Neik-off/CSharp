using System;


class BatGoikoTower
{
    static void Main()
    {
        int H = int.Parse(Console.ReadLine());
        char symbol = '.';
        int dash = 1;
        int step = 2;
        for (int i = 0; i < H; i++)
        {
            
            for (int j = 0; j < H*2; j++)
            {
                if(j==H-i-1)
                {
                    symbol = '/';
                }
                else if(j==H+i)
                {
                    symbol = '\\';
                }
                else if(i==dash && j>H-i-1 && j<H+i)
                {
                    symbol = '-';
                }
                else
                {
                    symbol='.';
                }
                Console.Write(symbol);                
            }
            if (i == dash)
            {
                dash += step;
                step++;
            }
            Console.WriteLine();
            
        }
    }
}
