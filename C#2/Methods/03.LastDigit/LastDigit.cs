using System;

class LastDigit
{
    static void Main()
    {
        Console.WriteLine("Enter Your Number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(GiveLastDigit(n));

    }
    static string GiveLastDigit(int number)
    {
        string digitName=null;
        int lastDigit=number%10;
        switch (lastDigit)
        {
            case 0: digitName="Zero"; break;
            case 1: digitName="One"; break;
            case 2: digitName="Two"; break;
            case 3: digitName="Three"; break;
            case 4: digitName="Four"; break;
            case 5: digitName="Five"; break;
            case 6: digitName="Six"; break;
            case 7: digitName="Seven"; break;
            case 8: digitName="Eight"; break;
            case 9: digitName = "Nine"; break;

            default:
                break;
        }
        return digitName;
    }
}