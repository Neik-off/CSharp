using System;

class ArrayAllocation
{
    static void Main()
    {
        int[] arr = new int[20];

        for (int i = 0; i < 20; i++)
        {
            arr[i] = i * 5;
        }

        foreach (int element in arr)
        {
            Console.WriteLine(element);
        }
    }
}