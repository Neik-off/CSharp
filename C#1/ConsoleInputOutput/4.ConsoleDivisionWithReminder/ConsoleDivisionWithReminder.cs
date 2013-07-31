using System;

class ConsoleDivisionWithReminder
{
    static void Main()
    {
        Console.WriteLine("Enter positive number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter other positive number:");
        int b = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = a ; i <= b; i++ )
        {
            if((i%5)==0)
            {
            Console.WriteLine("The nubmer {0} is dividing without reminder!",i);
            counter++;
            }
        }
        Console.WriteLine("From {0} to {1} there are {2} numbers that fulfills the condition!",a,b,counter);
    }
}
