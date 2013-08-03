using System;
using System.Collections.Generic;

class DigitsInArrays
{
    static void Main()
    {
        List<int> first = new List<int>();
        List<int> second = new List<int>();
        string read=null;
        Console.WriteLine("Enter the digits of your first number and enter \"end\" to stop!");
        while(read!="end")
        {
            read = Console.ReadLine();
            int number=0;
            if(int.TryParse(read,out number))
            {
                if (number <= 9)
                {
                    first.Add(number);
                }
                else
                {
                    Console.WriteLine("Wrong Digit!Value must be(0~9)! ");
                }     
            }            
        }
        read = null;
        Console.WriteLine("Enter the digits of your number and enter \"end\" to stop!");
        while (read != "end")
        {
            read = Console.ReadLine();
            int number = 0;
            if (int.TryParse(read, out number))
            {
                if (number <= 9)
                {
                    second.Add(number);
                }
                else 
                {
                    Console.WriteLine("Wrong Digit!Value must be(0~9)! ");
                }                
            }
        }
        int[] sum = GetSum(first,second);
        Console.Write("The Sum = ");
        for (int i = sum.Length - 1; i >= 0; i--)
        {
            if (i == sum.Length - 1 && sum[i] == 0)
            {
                continue;
            }
            Console.Write(sum[i]+"|");
        }
        Console.WriteLine();

    }
    static int[] GetSum(List<int> firstNumber,List<int> secondNumber)
    {
        firstNumber.Reverse();
        secondNumber.Reverse();
        int length = (firstNumber.Count <= secondNumber.Count ? firstNumber.Count : secondNumber.Count);
        int biggerLength = (firstNumber.Count >= secondNumber.Count ? firstNumber.Count : secondNumber.Count);
        string biggerNumber = (firstNumber.Count >= secondNumber.Count ? "first" : "second");
        int[] sum = new int[biggerLength + 1];

        //Sum Calculating
        for (int i = 0; i < length; i++)
        {
            int currentSum = firstNumber[i] + secondNumber[i];
            if (currentSum <= 9)
            {
                if (sum[i] + currentSum > 9)
                {
                    sum[i] = (currentSum + sum[i]) % 10;
                    sum[i + 1]++;
                }
                else
                {
                    sum[i] += currentSum;
                }
                
            }
            else
            {
                sum[i] += currentSum % 10;
                sum[i + 1]++;
            }
        }
        //Filling the number with non sumed digits
        if (biggerLength > length)
        {
            for (int i = length; i < biggerLength; i++)
            {
                if (biggerNumber=="first")
                {
                    sum[i] += firstNumber[i];
                }
                else
                {
                    sum[i] += secondNumber[i];
                }
            }
        }
        return sum;
    }
}