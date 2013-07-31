using System;

class NullableIntegers
{
    static void Main(string[] args)
    {
        int? i = null;
        double? d = null;
        Console.WriteLine("Null values: int="+i+" ,double="+d);
        i = 5;
        d = 5;
        Console.WriteLine("NotNull values: int=" + i + " ,double=" + d);
    }
}

