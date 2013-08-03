using System;

class GenericTypeMethods
{
    static void Main()
    {
        Console.WriteLine(Min(123L,12L,31.0D,123.0d,123.0f));
        Console.WriteLine(Max(123L, 12L, 31.0D, 123.0d, 123.0f));
        Console.WriteLine(Sum(123L, 12L, 31.0D, 123.0d, 123.0f));
        Console.WriteLine(Average(123L, 12L, 31.0D, 123.0d, 123.0f));
        Console.WriteLine(Product(123L, 12L, 31.0D, 123.0d, 123.0f));

    }
    static T Min<T>(params T[] elements)
    {
        dynamic min = elements[0];
        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] < min)
            {
                min = elements[i];
            }
        }
        return min;
    }
    static T Max<T>(params T[] elements)
    {
        dynamic max = elements[0];
        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i] > max)
            {
                max = elements[i];
            }
        }
        return max;
    }
    static T Average<T>(params T[] elements)
    {
        dynamic average = 0;
        dynamic sum = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            sum += elements[i];
        }
        average = sum / elements.Length;
        return average;
    }
    static T Sum<T>(params T[] elements)
    {
        dynamic sum = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            sum += elements[i];
        }
        return sum;
    }
    static T Product<T>(params T[] elements)
    {
        dynamic product = elements[0];
        for (int i = 1; i < elements.Length; i++)
        {
            product *= elements[i];
        }
        return product;
    }
}