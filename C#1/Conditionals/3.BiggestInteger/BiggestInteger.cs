using System;

class BiggestInteger
{
    static void Main()
    {
        int a=8, b=8, c=40;
        int? biggest=null;
        //Checks
        if(a>b)
        {
            if(a>c)
            {
                biggest = a;
            }
            else if(c>a)
            {
                biggest = c;
            }
        }
        else if(b>a)
        {
            if(b>c)
            {
                biggest = b;
            }
            else if(c>b)
            {
                biggest = c;
            }
        }
        else if(a==b)
        {
            if(c>a)
            {
                biggest = c;
            }
        }
        //Printing the result
        if (biggest != null)
        {
            Console.WriteLine("Biggest Number is:" + biggest);
        }
        else 
        {
            Console.WriteLine("There are no biggest number!");
        }

    }
}
