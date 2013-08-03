using System;

class ArraySSum
{
    static void Main()
    {
        int Sum = 11;
        int[] arr = { 4, 3, 1, 4, 2, 5, 8 };

        int SumStart = 0;
        int SumEnd = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int currentSum = arr[i];
            if (currentSum == Sum)
            {
                SumStart = i;
                SumEnd = i;
                break;
            }
            else if(currentSum>Sum)
            {
                continue;
            }
            for (int j = i+1; j < arr.Length; j++)
            {
                currentSum += arr[j];
                if (currentSum==Sum)
                {
                    SumStart = i;
                    SumEnd = j;
                    break;
                }
                else if(currentSum>Sum)
                {
                    break;
                }
            }
        }
        Console.Write("{");
        for (int i = SumStart; i <= SumEnd; i++)
        {
            Console.Write(arr[i]);
            if(i<SumEnd)
            {
               Console.Write(", ");
            }
        }
        Console.WriteLine("}");
    }
}