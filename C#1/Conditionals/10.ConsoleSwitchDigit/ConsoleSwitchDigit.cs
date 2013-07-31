using System;

class ConsoleSwitchDigit
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter your value:");
            int userValue;
            bool tryParse = int.TryParse(Console.ReadLine(), out userValue);

            if (!tryParse)
            {
                Console.WriteLine("Wrong Request!");
                continue;
            }
            switch (userValue)
            {
                case 1:
                case 2:
                case 3: Console.WriteLine(userValue *= 10);
                    break;
                case 4:
                case 5:
                case 6: Console.WriteLine(userValue *= 100);
                    break;
                case 7:
                case 8:
                case 9: Console.WriteLine(userValue *= 1000);
                    break;
                default: Console.WriteLine("Wrong Request!"); break;
            }
        }
    }
}
