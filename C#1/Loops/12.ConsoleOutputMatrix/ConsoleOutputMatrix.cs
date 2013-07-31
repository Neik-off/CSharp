using System;

class ConsoleOutputMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter Number:");
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        int firstValue = 1;

        for (int i = 0; i < n; i++)
        {
            
            for (int k = 0; k < n; k++)
            {
                if (k == 0)
                {
                    arr[i, k] = firstValue;
                }
                else
                {
                    arr[i, k] = arr[i, k - 1] + 1;
                }
                if(arr[i,k]>9)
                {
                    Console.Write(arr[i,k]+"|");
                }
                else
                {
                    Console.Write(" "+arr[i, k] + "|");
                }

                if(k==n-1)
                {
                    Console.WriteLine();
                }
            }
            firstValue++;
        }
    }
}
