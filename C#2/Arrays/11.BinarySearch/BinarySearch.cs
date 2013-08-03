using System;

class BinarySearch
{
    static int[] arr = { 3, 4, 6, 7, 87, 1, 7, 
                        98, 9021, 87, 9, 8, 7, 
                        9, 0, 6, 7, 86, 27, 78,
                        678, 2, 771, 6, 78, 8, 87, 
                        3232, 37, 8, 99, 8, 33, 434, 
                        3, 1, 8, 13, 21, 3123, 124, 
                        1423, 324, 37, 8687, 87, 67, 123 };
    static void Main()
    {
        //Searched Number X
        int x = -5000;
        //Sorting
        selectionSort(0,arr.Length);
        //BinarySearching
        int index=binarySearch(0, arr.Length, x);
        //Printing
        Console.Write("{ ");
        foreach (int element in arr)
        {
            Console.Write(element+", ");
        }
        Console.WriteLine("}");
        if(index!=-1)
            Console.WriteLine("The index of number, {0} in the array is {1}.",arr[index],index);
        else
            Console.WriteLine("No match for the searching number!");

    }
    static int binarySearch(int lo,int hi,int x) 
    {
        int middleIndex = lo + ((hi-lo) / 2);
        int middle = arr[middleIndex];
        
        if (lo>hi)
        {
            return -1;
        }
        else if (x>middle)
        {
           return binarySearch( middleIndex+1, hi, x);
        }
        else if (x < middle)
        {
            return binarySearch(lo, middleIndex-1, x);
        }
        else
        {
            return middleIndex;
        }
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
