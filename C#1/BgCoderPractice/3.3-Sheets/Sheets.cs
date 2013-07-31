using System;

class Sheets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sheet = 10;
        for (int i = 0; i < 11; i++,sheet--)
        {
            int bit = (n >> i) & 1;
            if (bit==0)
            {
                Console.WriteLine("A"+sheet);
            }
        }
    }
}