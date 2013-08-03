using System;

class NKCombinations
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr=new int[k];
        combinations(arr,0,n,1);


    }
    static void combinations(int[]arr,int current,int n,int previous) 
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
            for (int i = previous; i <= n; i++)
            {
                arr[current] = i;
                combinations(arr,current+1,n,i+1);
            }
        }
    }
}