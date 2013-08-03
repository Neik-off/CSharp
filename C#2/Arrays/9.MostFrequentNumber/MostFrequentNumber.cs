using System;

class MostFrequentNumber
{
    static void Main()
    {
        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        int maxFrequency = 0;
        int mostFreqNumber = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int currNumber = arr[i];
            int currFrequency = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == currNumber)
                {
                    currFrequency++;
                }
            }
            if (currFrequency > maxFrequency)
            {
                maxFrequency = currFrequency;
                mostFreqNumber = currNumber;
            }
        }
        Console.WriteLine("The most frequent number is {0}, with frequency({1}).", mostFreqNumber, maxFrequency);
    }
}
