using System;

class LoopConsoleRead
{
    static void Main()
    {
        Console.WriteLine("Enter N(the size of number's sequence):");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int [n];
        int min=0, max=0;
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Enter number from the sequence:");
            arr[i] = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                min = max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("The minimal number is:{0} and the maximal nubmer is:{1}",min,max);

    }
}
