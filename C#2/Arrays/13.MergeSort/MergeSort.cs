using System;
using System.Collections.Generic;

class MergeSort
{
    

    static void Main()
    {
        List<int> arr = new List<int>();
        Random rd = new Random();
        //Filling the List<int> with random Integers
        for (int i = 0; i < 100; i++)
        {
            arr.Add(rd.Next(100));
        }        
        //Printing Shuffled List<int>
        Console.WriteLine("Before The Sorting:");
        Console.WriteLine(new string('-', 77));
        for (int i = 0; i < arr.Count;i++ )
        {
            Console.Write(arr[i] + ", ");
            if(i%19==0&&i>1)
            {
                Console.WriteLine();
            }
        }
        //Separator
        Console.WriteLine();
        Console.WriteLine(new string('-', 77));
        Console.WriteLine("After The Sorting:");
        Console.WriteLine(new string('-', 77));
        //Sorting
        arr=mergeSort(arr);
        //Printing Sotred List<int>
        for (int i = 0; i < arr.Count; i++)
        {
            Console.Write(arr[i] + ", ");
            if (i % 19 == 0 && i > 1)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', 77));
    }
    static List<int> mergeSort(List<int> arr)
    {
        if(arr.Count<=1)
        {
            return arr;
        }
        List<int> left = new List<int>(), right = new List<int>();

        int middle = arr.Count / 2;
        for (int i = 0; i < middle; i++)
        {
            left.Add(arr[i]);
        }
        for (int i = middle; i < arr.Count; i++)
        {
            right.Add(arr[i]);
        }
        left = mergeSort(left);
        right = mergeSort(right);

        return merge(left, right);
    }
    static List<int> merge(List<int> left,List<int> right) 
    {
        List<int> result=new List<int>();
        while(left.Count>0||right.Count>0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if(left[0]<=right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            else if (left.Count>0)
            {
                result.AddRange(left);
                left.Clear();
            }
            else if (right.Count > 0)
            {
                result.AddRange(right);
                right.Clear();
            }

        }
        return result;
    }
}