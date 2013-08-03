using System;

class MaximalSeqeunceSum
{
    static void Main()
    {
        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int sumTillNow = arr[0];
        int currentBegin = arr[0];
        int maxSum = arr[0];
        int maxSumBegin = 0;
        int maxSumEnd = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (sumTillNow<0)
            {
                sumTillNow = arr[i];
                currentBegin = i;
            }
            else
            {
                sumTillNow += arr[i];
            }
            if (sumTillNow>maxSum)
            {
                maxSum = sumTillNow;
                maxSumBegin = currentBegin;
                maxSumEnd = i;
            }
        }
        Console.Write("{ ");
        for (int i = maxSumBegin; i <= maxSumEnd; i++)
        {
            Console.Write(arr[i]);
            if(i<maxSumEnd)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(" }");
    }
}