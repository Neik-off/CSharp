using System;

class NumberCountInArray
{
    static void Main()
    {
        int[] arr = { 1,2,3,4,6,6,6,2,98,10};
        int n = 6;
        Console.WriteLine("The times N appears in the array are:{0}",Count(n,arr));

    }
    static int Count(int number,int[]arr) 
    {
        int count=0;
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i]==number)
            {
                count++;
            }
        }
        return count;
    }
}