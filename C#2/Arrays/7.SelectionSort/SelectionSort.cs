using System;

class SelectionSort
{
    static int[] arr = { 9, 6, 7, 8, 6, -1, 0, 1337, 2, 3, 512, 129, 230, 69, 7, 34, 78, 24, 8, 99 };

    static void Main()
    {
        selectionSort(0, arr.Length);
        Console.Write("{ ");
        foreach (int element in arr)
        {
            Console.Write(element + ", ");
        }
        Console.WriteLine("}");
    }

    static void selectionSort(int lo, int hi)
    {
        int smaller = arr[lo];
        int tempIndex = 0;

        for (int i = lo + 1; i < hi; i++)
        {
            if (arr[i] < smaller)
            {
                smaller = arr[i];
                tempIndex = i;
            }
        }
        if (smaller != arr[lo])
        {
            int temp = arr[lo];
            arr[lo] = smaller;
            arr[tempIndex] = temp;
        }
        if (lo < hi - 1)
        {
            selectionSort(lo + 1, hi);
        }

    }
}
