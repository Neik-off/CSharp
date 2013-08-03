using System;

class MaximalSequence
{
    static void Main()
    {
        int[] arr ={3,2,3,4,2,2,3,4,5,1,1,1,2,3,4,5};
        int maxSequence = 0;
        int maxSequenceElement = 0;
        int currentSequence = 0;
        int currentSequenceElement = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (i > 0 && arr[i] != arr[i - 1]+1)
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
            if(currentSequence>maxSequence)
            {
                maxSequence = currentSequence;
                maxSequenceElement = currentSequenceElement;
            }

        }

        Console.Write("{");
        for (int i = 0; i < maxSequence; i++)
        {
            Console.Write(maxSequenceElement+i);
            if(i<maxSequence-1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine("}");
    }
}