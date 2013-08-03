using System;

class OperationsClass
{
    static void Main(string[] args)
    {
        Console.WriteLine(Min(1,23,1,231,3,13,1,3));
        Console.WriteLine(Max(1,231,3,123,1,4));
        Console.WriteLine(Average(12,2,2,4,4,7,8,98,87));
        Console.WriteLine(Sum(7890,866,2,62,832,8,438,48,3,87,89,790,789));
        Console.WriteLine(Product(1,3,126,243,734,848,34));
    }
    static int Min(params int[] elements)
    {
        int min = elements[0];
        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] < min)
            {
                min = elements[i];
            }
        }
        return min;
    }
    static int Max(params int[] elements)
    {
        int max = elements[0];
        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] > max)
            {
                max = elements[i];
            }
        }
        return max;
    }
    static double Average(params int[] elements)
    {
        double average = 0;
        int sum = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            sum += elements[i];
        }
        average = sum / elements.Length;
        return average;
    }
    static int Sum(params int[] elements)
    {
        int sum = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            sum += elements[i];
        }
        return sum;
    }
    static long Product(params int[] elements)
    {
        long product = elements[0];
        for (int i = 1; i < elements.Length; i++)
        {
            product *= elements[i];
        }
        return product;
    }
}