using System;

class GetMaxClass
{
    static void Main()
    {
        Console.WriteLine("Enter Number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Number:");
        int c = int.Parse(Console.ReadLine());
        int d = GetMax(a,b);
        Console.WriteLine("The Bigger one is:");
        Console.WriteLine(GetMax(d,c));
    }
    static int GetMax(int first,int second)
    {
        int bigger = first;
        if(second>first)
        {
            bigger = second;
        }
        return bigger;
    }
}
