using System;
using System.Collections.Generic;

class MenuOfOperations
{
    static void Main()
    {
        bool exit = false;
        while(!exit)
        {
            PrintMenu();
            int request = 0;
            bool check =int.TryParse(Console.ReadLine(),out request);
            if (check)
            {
                switch (request)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Enter number you want to reverse(Max value:{0})", long.MaxValue);
                        long usersNumber = 0;
                        bool checking = long.TryParse(Console.ReadLine(),out usersNumber);
                        if (checking)
                        {
                            Console.Clear();
                            Console.WriteLine("Rreversed number ={0}", ReverseDigit(usersNumber));
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine("You must reverse number!");
                            break;                             
                        }
                        break;
                    case 2:
                        decimal Number = 0;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Enter number of the sequence(Press only \"Enter\" to complete the sequence):");
                        bool cont = decimal.TryParse(Console.ReadLine(), out Number);
                        List<decimal> sequence = new List<decimal>();
                        while (cont)
                        {
                            Console.WriteLine("Enter number of the sequence(Press only \"Enter\" to complete the sequence):");
                            sequence.Add(Number);
                            cont = decimal.TryParse(Console.ReadLine(), out Number);
                        }
                        if (sequence.Count==0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine("The sequence must not be empty!");
                            break;
                        }
                        Console.Clear();
                        Console.WriteLine("The average value in your sequence is {0}", Avarage(sequence.ToArray()));
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The equalation is -> a*x+b=0 <-");
                        Console.WriteLine("Enter A:");
                        double A = -1;
                        bool aCorrect = double.TryParse(Console.ReadLine(), out A);
                        if (A==0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine("The value of A must be NUMBER without 0!");
                            break;
                        }
                        Console.WriteLine("Enter B:");
                        double B =0;
                        bool bCorrect= double.TryParse(Console.ReadLine(),out B);
                        if (aCorrect&&bCorrect)
                        {
                            Console.Clear();
                            Console.WriteLine("X is equal to: {0:F2}", LinearEqualation(A, B));                            
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong input! Enter Numbers For A and B!");
                        }
                        break;
                    case 0:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Bye Bye! :)");
                        exit = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("No such command!");
                        break;
                }
            }
            else 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong input! Enter Number!");
            }            
        }
    }
    static void PrintMenu()
    {
        Console.ForegroundColor = ConsoleColor.White;        
        Console.WriteLine(new string('-',50));
        Console.WriteLine("Menu:");
        Console.WriteLine("For Reversing Digits of number: Enter 1 ");
        Console.WriteLine("For Average value of sequence: Enter 2");
        Console.WriteLine("For Solving lenear equalation: Enter 3");
        Console.WriteLine("For Exit -->Enter 0!");
        Console.WriteLine("Your choice is:");
        Console.ForegroundColor = ConsoleColor.Gray;  
    }
    static long ReverseDigit(long number)
    {
        string reversed = null;
        while (number>0)
        {
            reversed += number % 10;
            number /= 10;
        }
        return long.Parse(reversed);
    }
    static decimal Avarage(decimal [] sequence)
    {
        decimal avarage = 0;
        decimal sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        avarage = sum / sequence.Length;
        return avarage;
    }
    static double LinearEqualation(double A, double B)
    {
        double x = 0;
        x = -B / A;
        return x;
    }
}
