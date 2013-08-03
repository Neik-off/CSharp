using System;

public class NeighboursChecker
{
    static void Main(string[] args)
    {
        int[] arr = {467,62,786,78,678,61,78,36,367,6,78,3,62,62,78,38,832 };
        Console.WriteLine(Check(arr,0));
    }
    public static bool Check(int[] arr,int index) 
    {
        if (index!=0&&index!=arr.Length-1)
        {
            return arr[index] > arr[index - 1] && arr[index] > arr[index + 1];
        }
        else if (index == 0)
        {
            return arr[index] > arr[index + 1];
        }
        else 
        {
            return arr[index] > arr[index - 1];
        }
    }
}