﻿using System;

class SingleLineIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter n Number:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n;i++ )
        {
            Console.WriteLine(i);
        }
    }
}