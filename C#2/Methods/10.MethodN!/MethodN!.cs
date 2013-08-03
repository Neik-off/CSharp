using System;

class MethodN
{
    static void Main()
    {
        int[] arr = {1};

        for (int i = 1; i <= 100; i++)
        {
            arr = Multiply(arr, i);
            Console.Write("{0}!= ",i);
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j]);
            }
            Console.WriteLine();
        }
    }
    static int[] Multiply(int[]arr,int Number)
    {
        int lengthBoost = 1;
        if (Number > 26)
        {
            lengthBoost++;
        }
        int[]result=new int [arr.Length+lengthBoost];
        int count = 1;
        int multiplier = Number % 10;
        while (multiplier > 0 || Number == 10 || Number == 20 || Number == 30 || Number == 40 || Number == 50 || Number == 60 
            || Number == 70 || Number == 80 || Number == 90 || Number == 100)
        {
            for (int i = arr.Length - 1, index = result.Length - count; i >= 0; i--, index--)
            {
                int currentSum = arr[i] * multiplier;
                if (currentSum > 9)
                {
                    if ((result[index] + currentSum % 10) < 10)
                    {
                        result[index] += currentSum % 10;
                        currentSum /= 10;
                        result[index - 1] += currentSum;
                    }
                    else
                    {
                        result[index] = (result[index] + currentSum % 10) % 10;
                        result[index - 1]++;
                        currentSum /= 10;
                        result[index - 1] += currentSum;
                    }
                }
                else
                {
                    if (result[index] + currentSum > 9)
                    {
                        result[index] = (result[index] + currentSum) % 10;
                        result[index - 1]++;
                    }
                    else
                    {
                        result[index] += currentSum;
                    }
                }
            }
            count++;
            Number /= 10;
            multiplier = Number % 10;
        }
        
        
        return result;
    }
}