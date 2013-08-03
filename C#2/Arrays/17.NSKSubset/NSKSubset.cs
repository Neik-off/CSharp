using System;
using System.Collections.Generic;

class NSKSubset
{
    static void Main()
    {
        Console.WriteLine("Enter N number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K number:");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter S number:");
        int s = int.Parse(Console.ReadLine());

        int [] arr=new int[n];
        //Filling the array
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter Nubmer for the array:");
            arr[i] = int.Parse(Console.ReadLine());
        }
        //Seaching for subsets
        List<int> subset = new List<int>();
        double combinations = Math.Pow(2, arr.Length);
        for (int i = 1; i < combinations; i++)
        {
            int currentSum = 0;
            int membersOfTheSum = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                int bit = (i >> j) & 1;
                if (bit == 1)
                {
                    membersOfTheSum++;
                    currentSum += arr[j];
                    subset.Add(j);
                }
            }
            if(membersOfTheSum!=k)
            {

                subset.Clear();
                continue;
            }
            if (currentSum == s)
            {
                Console.Write("Yes->(");
                for (int index = 0; index < subset.Count; index++)
                {
                    Console.Write(arr[subset[index]] + " ");
                }
                Console.WriteLine(")");
                break;
            }
            subset.Clear();
            if (i == combinations - 1)
            {
                Console.WriteLine("No such subset in the array!");
            }
        }
    }
}