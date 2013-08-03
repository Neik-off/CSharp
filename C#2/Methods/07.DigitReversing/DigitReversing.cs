using System;

class DigitReversing
{
    static void Main()
    {
        int n = 2560;
        Console.WriteLine(Reverse(n));
    }
    static int Reverse(int number)
    {
        string reversedString = null;
        while(number>0)
        {
            reversedString+=(number%10);
            number /= 10;
        }
        int reversed = int.Parse(reversedString);
        return reversed;
    }
}
