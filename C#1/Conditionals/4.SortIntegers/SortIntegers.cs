using System;

class SortIntegers
{
    static void Main()
    {
        int a = 4, b = 2, c = 5;

        if (a > b)
        {
            if (b >= c)
            {
                Console.WriteLine("The order:{0},{1},{2}", a, b, c);
            }
            else if(a >= c)
            {
                Console.WriteLine("The order:{0},{1},{2}", a, c, b);
            }
        }
        else if(b > a)
        {
            if(a >= c)
            {
                Console.WriteLine("The order:{0},{1},{2}", b, a, c);
            }
            else if(b >= c)
            {
                Console.WriteLine("The order:{0},{1},{2}", b, c, a);
            }
        }        
        if (c > b)
        {
            if (b >= a)
            {
                Console.WriteLine("The order:{0},{1},{2}", c, b, a);
            }
            else if (c >= a)
            {
                Console.WriteLine("The order:{0},{1},{2}", c, a, b);
            }
        }
        else
        {
            Console.WriteLine("The integers are equal!");
        }
        

    }
}
