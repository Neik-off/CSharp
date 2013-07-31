using System;

class FallDown
{
    static void Main()
    {
        int [] arr = new int[8];
        int [,] table=new int[8,8];

        for (int i = 0; i < 8; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                int bit = (arr[i]>>j)&1;
                table[i,j]=bit;
            }
        }

        for (int k = 0; k < 8; k++)
        {
            for (int i = 7; i >= 0; i--)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (table[i, j] == 0)
                    {
                        if (i > 0 && table[i - 1, j] == 1)
                        {
                            table[i - 1, j] = 0;
                            table[i, j] = 1;
                        }
                    }

                }
            }            
        }

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                int bit = table[i, j];
                if (bit==1)
                {
                    arr[i] = arr[i] | (bit << j);
                }
                else
                {
                    bit = 1;
                    arr[i]= arr[i] & (~(bit<<j));
                }
                
            }
            Console.WriteLine(arr[i]);
        }      
    }
}