using System;
using System.Collections.Generic;

class Subset
{
    static void Main()
    {
        int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int S = 14;
        List<int> subset = new List<int>();
        double combinations = Math.Pow( 2 , arr.Length);
        for (int i = 1; i < combinations; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                int bit = (i >> j) & 1;
                if(bit==1)
                {
                    currentSum += arr[j];
                    subset.Add(j);
                }
            }
            if(currentSum==S)
            {
                Console.Write("Yes->(");
                for (int k = 0; k < subset.Count; k++)
                {
                    Console.Write(arr[subset[k]]+" ");
                }
                Console.WriteLine(")");
                break;
            }
            subset.Clear();
            if(i==combinations-1)
            {
                Console.WriteLine("No such subset in the array!");
            }
        }
    }
}
