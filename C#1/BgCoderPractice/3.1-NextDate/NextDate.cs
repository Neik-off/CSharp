using System;

class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        DateTime today = new DateTime(year,month,day);
        DateTime tomorow = new DateTime();
        tomorow =today.AddDays(1);
        Console.WriteLine("{0:d.M.yyyy}" , tomorow);
        
    }
}
