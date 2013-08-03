using System;

class NeighbourChecker2
{
    static void Main(string[] args)
    {
        int[] arr = {1,2,3,4,5,6,7,12,3,14,12,4,67,87 };
        Console.WriteLine("The index of the first Number bigger than its neighbours is:{0}"+GetIndex(arr));
    }
    static int GetIndex(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (NeighboursChecker.Check(arr, i))
            {
                return i;
            }
        }
        return -1;
    }
}