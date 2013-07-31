using System;

class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] symbols =new char[n,n];


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == n / 2 - 1 - i)
                {
                    symbols[i, j] = '/';
                }
                else if(i<n/2&&j<n/2&&j>0&& symbols[i,j-1]=='/')
                {
                    symbols[i,j]=' ';
                }
                else if (i < n / 2 && j < n / 2 && j > 0 && symbols[i, j - 1] == ' ')
                {
                    symbols[i, j] = '/';
                }
                    //Right
                else if (j>=n/2 && i<n/2)
                {
                    if (symbols[ i, n - 1 - j] == '.')
                    {
                        symbols[i, j] = '.';
                    }
                    else if (symbols[ i, n - 1 - j] == '/')
                    {
                        symbols[i, j] = '\\';
                    }
                    else if (symbols[ i, n - 1 - j] == '\\')
                    {
                        symbols[i, j] = '/';
                    }
                    else if (symbols[ i,n - 1 - j] == ' ')
                    {
                        symbols[i, j] = ' ';
                    }
                }
                    //Bottom
                else if(i>=n/2)
                {
                    if(symbols[n-1-i,j] =='.')
                    {
                        symbols[i, j] = '.';
                    }
                    else if (symbols[n - 1 - i, j ] == '/')
                    {
                        symbols[i, j] = '\\';
                    }
                    else if (symbols[n - 1 - i,j] == '\\')
                    {
                        symbols[i, j] = '/';
                    }
                    else if (symbols[n - 1 - i,j] == ' ')
                    {
                        symbols[i, j] = ' ';
                    }
                }
                else
                {
                    symbols[i, j] = '.';
                }
                Console.Write(symbols[i,j]);               
            }
            Console.WriteLine();
        }
    }
}