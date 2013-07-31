using System;

class Fibonacci
{
    static void Main()
    {
        Console.WriteLine("Enter size of Fibonacci sequence:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.Write("{");
        for (int i = 0; i < arr.Length ; i++)
        {
            if(i==0)
            {
                arr[i]=0;
            }
            else if (i ==1 )
            {
                arr[i] = 1;
            }
            else
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            Console.Write(arr[i]+" ");
        }
        Console.WriteLine("}");
    }
}
