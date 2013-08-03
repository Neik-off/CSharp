using System;

class Polynomials
{
    static void Main()
    {
        int[] P = { 5,0,1,2};
        int[] Q = { 6,2,9};
        int[] sum = AddPolynomials(P,Q);
        for (int i = 0; i < sum.Length; i++)
        {
            Console.Write(sum[i]+"|");
        }
    }
    static int[] AddPolynomials(int[] A,int[] B)
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
                result[i] += B[i] + A[i];
            }
        }
        return result;
    }
}