using System;

class MissCat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int winner = 0;
        int[] arr = new int[11];

        for (int i = 0; i < n; i++)
        {
            arr[int.Parse(Console.ReadLine())]++;
        }
        for (int i = 0,bigger=0,biggerIndx=0; i < arr.Length; i++)
        {
            if (arr[i] > bigger) 
            {
                bigger = arr[i];
                biggerIndx = i;
            }
            else if (arr[i] == bigger)
            {
                if(biggerIndx>i)
                {
                    bigger = arr[i];
                    biggerIndx = i;
                }
            }
            winner = biggerIndx;
        }
        Console.WriteLine(winner);
    }
}
