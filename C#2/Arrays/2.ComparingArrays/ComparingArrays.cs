using System;

class ComparingArrays
{
    static void Main()
    {
        Console.WriteLine("Enter Length for the array's:");
        int length = int.Parse(Console.ReadLine());
        int[] arr1 = new int[length];
        int[] arr2 = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Enter value for first array:");
            arr1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for second array:");
            arr2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < length; i++)
        {
            string bigger="second";
            if(arr1[i]>arr2[i])
            {
                bigger = "first";
            }
            else if(arr1[i]==arr2[i])
            {
                bigger = "equal";
            }
            if(bigger=="equal")
            {
                Console.WriteLine("The value's for current index({0}) are equal!",i);
            }
            else
            {
                Console.WriteLine("Bigger value for current index({0}) is in the {1} array!",i,bigger);
            }
            
        }
    }
}