using System;

class ArrayBinSearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());            
        }

        Array.Sort(arr);
        int index = Array.BinarySearch(arr,k);
        if (k<arr[0])
        {
            Console.WriteLine("There is no such element!");
        }
        else if (index >= 0)
        {
            Console.WriteLine("The number is:{0}", arr[index]);
        }
        else 
        {
            Console.WriteLine("The number is:{0}",arr[-index-2]);
        }
    }
}