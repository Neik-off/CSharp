using System;

class GreatestNumber
{
    static void Main()
    {
        int a=40, b=21, c=32, d=47, i=10, k=20;
        int greatest=a;
        if(b>greatest)
        {
            greatest = b;
        }
        if (c > greatest)
        {
            greatest = c;
        }
        if (d > greatest)
        {
            greatest = d;
        }
        if (i > greatest)
        {
            greatest = i;
        }
        if (k > greatest)
        {
            greatest = k;
        }
        Console.WriteLine("The Greatest Number is:{0}",greatest);
    }
}
