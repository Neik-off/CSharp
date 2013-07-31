using System;

class NumbersSum
{
    static void Main()
    {
        Console.WriteLine("Enter n Numbers count:");
        int n = int.Parse(Console.ReadLine());
        int sum=0;

        for (int i = 1; i <= n; i++ )
        {

            Console.WriteLine("Enter {0} Number:",i);
            int a = int.Parse(Console.ReadLine());
            sum +=a;

        }        
        Console.WriteLine("The sum is:"+sum);
    }
}
