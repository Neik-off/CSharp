using System;

class SubtractionMultiplyPolynomials
{
    static void Main()
    {
        int[] P = { 5, 0, 1, 0, 0, 1, 5 };
        int[] Q = { 6, 2, 9, 23, 1, 6, 2, 13 };
        int[] subtract = Subtraction(Q,P);
        Console.WriteLine("Subtraction");
        for (int i = 0; i < subtract.Length; i++)
        {
            Console.Write(subtract[i] + "|");
        }
        Console.WriteLine();
        int[] multiply = Multiply(Q,P);
        Console.WriteLine("Multiply");
        for (int i = 0; i < subtract.Length; i++)
        {
            Console.Write(multiply[i] + "|");
        }
        Console.WriteLine();
    }
    static int[] Subtraction(int[] A, int[] B)
    {
        int length = (A.Length <= B.Length ? A.Length : B.Length);
        int biggerLength = (A.Length >= B.Length ? A.Length : B.Length);
        int[] longer = (A.Length >= B.Length ? A : B);
        int[] result = new int[biggerLength];
        for (int i = 0; i < biggerLength; i++)
        {
            if (i >= length)
            {
                result[i] = longer[i];
            }
            else
            {
                result[i] -= B[i] - A[i];
            }
        }
        return result;
    }
    static int[] Multiply(int[] A, int[] B)
    {
        int length = (A.Length <= B.Length ? A.Length : B.Length);
        int biggerLength = (A.Length >= B.Length ? A.Length : B.Length);
        int[] shorter = (A.Length <= B.Length ? A : B);
        int[] longer = (A.Length >= B.Length ? A : B);
        int[] result = new int[biggerLength];
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < biggerLength; j++)
            {
                result[j]+=shorter[i]*longer[j];
            }
        }
        return result;
    }
}