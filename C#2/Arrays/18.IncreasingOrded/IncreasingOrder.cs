using System;
using System.Collections.Generic;

class IncreasingOrder
{
    static void Main()
    {
        List<int> arr = new List<int> { 6, 1, 4, 3, 0, 3, 6, 4, 5 };

        int previousNumber = int.MinValue;
        for (int i = 0; i < arr.Count-1; i++)
        {
            if(arr[i]>=previousNumber && arr[i+1]>=previousNumber)
            {
                if (arr[i] >= arr[i + 1])
                {
                    previousNumber = arr[i + 1];
                    arr.RemoveAt(i);                    
                }
                else 
                {
                    previousNumber = arr[i];
                    arr.RemoveAt(i+1);
                }
            }
            else if(arr[i]>=previousNumber)
            {
                previousNumber = arr[i];
                arr.RemoveAt(i + 1);
            }
            else if (arr[i + 1] >= previousNumber)
            {
                previousNumber = arr[i + 1];
                arr.RemoveAt(i);
            }
            else
            {
                arr.RemoveAt(i);
                arr.RemoveAt(i+1);
            }
        }


        //Printing the ramaining array
        foreach (int item in arr)
        {
            Console.Write(item+" ");            
        }
    }
}
