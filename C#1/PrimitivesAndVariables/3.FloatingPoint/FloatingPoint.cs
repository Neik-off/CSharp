using System;

class FloatingPoint
{
    static void Main(string[] args)
    {
        float a=5.00000001F,b=5.00000003F;
        if (a.Equals(b))
        {
            Console.WriteLine("A equals B? " + true);
        }
        else
        {
            Console.WriteLine("A equals B? " + false);
        }
    }
}

