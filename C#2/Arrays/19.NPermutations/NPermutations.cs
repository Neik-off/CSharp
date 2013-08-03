using System;

class NPermutations
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[]arr=new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = i + 1;
        }
        Permutation(arr,0,n-1);
    }
    static void swap(ref int first,ref int second) 
    {
        int temp = first;
        first = second;
        second = temp;
    }
    static void Permutation(int[]arr,int current,int length) 
    {
        if (current == length)
        {
            for (int i = 0; i <= length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        else 
        {
            for (int i = current ; i <= length; i++)
            {
                swap(ref arr[i],ref arr[current]);
                Permutation(arr,current+1,length);
                swap(ref arr[i],ref arr[current]);

            }
        }
    }
}
