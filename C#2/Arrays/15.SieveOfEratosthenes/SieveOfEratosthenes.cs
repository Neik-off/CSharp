using System;
using System.Collections.Generic;

class SieveOfEratosthenes
{
    static void Main()
    {
        bool[] arr=new bool[10000001];
        
        for (int i = 2; i*i <= arr.Length; i++)
        {      
            if(!arr[i])
            {
                for (int j = i*i; j < arr.Length; j+=i)
                {
                    arr[j] = true;
                }
            }
        }
        Console.WriteLine("The prime numbers from the list:");
        for (int i = 2; i < arr.Length; i++)
        {
            if (!arr[i])
            {
                Console.Write(i+" ");
            }
        }
        Console.WriteLine();
    }
}