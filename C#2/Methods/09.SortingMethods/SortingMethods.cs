using System;

class SortingMethods
{
    static void Main()
    {
        int[] arr = { 1,2,3,1234,62,81,19,48,67,26,37,87,8,2436,624,73 };
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "|");
        }
        Console.WriteLine("\nAscendingSort");
        arr = AscendingSort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "|");
        }
        Console.WriteLine("\nDescendingSort");
        arr = DescendingSort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+"|");
        }
        Console.WriteLine();
    }
    static int GetBiggest(int[]arr,int index)
    {
        int biggest = arr[index];
        int biggestIndex=index;
        for (int i = index; i < arr.Length; i++)
        {
            if (arr[i]>biggest)
            {
                biggest = arr[i];
                biggestIndex = i;
            }
        }
        return biggestIndex;
    }
    static int[] AscendingSort(int[] arr)
    {
        int[] sorted=new int[arr.Length];
        arr = DescendingSort(arr);
        for (int i = 0,index=arr.Length-1; i < arr.Length; i++,index--)
        {
            sorted[index] = arr[i];
        }
        return sorted;
    }
    static int[] DescendingSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int temp = arr[i];
            int index = GetBiggest(arr, i);
            arr[i] = arr[index];
            arr[index]=temp;
        }
        return arr;
    }
}