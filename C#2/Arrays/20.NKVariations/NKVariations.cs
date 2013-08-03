using System;

class NKVariations
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[]arr =new int[k];

        variation(arr,0,n);
    }
    static void variation(int[] arr,int current,int n) 
    {
        if (current>arr.Length-1)
        {
            foreach (int item in arr)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
        else 
        {
            for (int i = 1; i <= n; i++)
            {
                arr[current] = i;
                variation(arr,current+1,n);
            }
        }
    }

}