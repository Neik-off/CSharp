using System;

class EqualSequence
{
    static void Main()
    {
        int[] arr ={2,1,1,2,3,3,2,2,2,1};
        int longestSequence = 0;
        int longestSequenceElement = 0;
        int currentSequence = 0;
        int currentSequenceElement = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (i > 0 && arr[i] != arr[i - 1])
            {
                currentSequence = 1;
                currentSequenceElement = arr[i];
            }
            else if (i == 0)
            {
                currentSequence++;
                currentSequenceElement = arr[0];
            }
            else
            {
                currentSequence++;
            }
            if(currentSequence>longestSequence)
            {
                longestSequence = currentSequence;
                longestSequenceElement = currentSequenceElement;
            }

        }

        Console.Write("{");
        for (int i = 0; i < longestSequence; i++)
        {
            Console.Write(longestSequenceElement);
            if(i<longestSequence-1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine("}");
    }
}
