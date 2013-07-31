using System;
using System.Text;

class PrimeNumberChecker
{
    static void Main()
    {
        bool prime = true;
        int divider = 2;
        
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Enter Number N( n ≤ 100):");
        int n = int.Parse(Console.ReadLine());        
        
        while(divider<(int)Math.Sqrt(n))
        {
            if(n%divider==0)
            {
                prime = false;
            }
                divider++;            
        }
        Console.WriteLine("Is the number prime?" + prime);
    }
}

