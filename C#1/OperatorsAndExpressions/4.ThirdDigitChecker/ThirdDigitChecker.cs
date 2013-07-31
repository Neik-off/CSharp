using System;

class ThirdDigitChecker
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Integer:");
        int userNumber = int.Parse(Console.ReadLine());
        //Modify the number so we get 7 as last digit
        int modificatedNumber = userNumber / 100;
        //Check the remainder of dividing with 10
        if (modificatedNumber % 10 == 7)
        {
            Console.WriteLine("The digit is 7!");
        }
        else
        {
            Console.WriteLine("The digit isn't 7!");
        }
    }
}

