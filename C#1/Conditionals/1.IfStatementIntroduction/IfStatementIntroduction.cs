using System;

class IfStatementIntroduction
{
    static void Main()
    {
        Console.WriteLine("Enter the first number");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        int b = int.Parse(Console.ReadLine());
        if(a>b)
        {
            int temp=a;
            a = b;
            b = temp;
        }
        Console.WriteLine("First Number:"+a+" | Second Number:"+b);
    }
}
