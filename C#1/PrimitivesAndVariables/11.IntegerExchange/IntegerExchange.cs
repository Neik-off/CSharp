using System;

class IntegerExchange
{
    static void Main()
    {
        int firstInt = 5;
        int secondInt = 10;
        int tempInt = 0;
        //Before Exchange!
        Console.WriteLine("Before Exchange->>"+"FirstInteger:"+firstInt+" SecondInteger:"+secondInt);
        //After Exchange
        tempInt = firstInt;
        firstInt = secondInt;
        secondInt = tempInt;
        Console.WriteLine("After Exchange->>"+"FirstInteger:"+firstInt+" SecondInteger:"+secondInt);
    }
}

