using System;

class FibonacciNumbers
{
    static void Main()
    {
        FibonacciNumbers fn = new FibonacciNumbers();
        for (int i = 0; i <= 100;i++ )
        {
            Console.WriteLine("Fibonacci Number {0} is:{1}",i,fn.fibonacci(i));
        }
        

    }

    public long fibonacci(long i)
    {
        if(i==0)
        {
            return 0;
        }
        else if (i == 1)
        {
            return 1;
        }
        else
        {
            return  fibonacci(i - 1) + fibonacci(i - 2);
        }
        
        
    }
}
