using System;

class EuclideanAlgorithm
{
    static void Main()
    {
        int i=18, k=12;
        GCD(i, k);
    }

    public static void GCD(int i,int k ) 
    {
        int divider=0, posibleDivider=0, divident = 0 ;
        if (i > k)
        {
            divider = k;
            posibleDivider = divider;
            divident = i;
        }
        else 
        {
            divider = i;
            posibleDivider = divider;
            divident = k;
        }

        while (divider != 0)
        {
            divider = divident % posibleDivider;
            divident = posibleDivider;
            if (divider == 0)
            {
                Console.WriteLine(posibleDivider);
            }
            posibleDivider = divider;
        }
    }
}