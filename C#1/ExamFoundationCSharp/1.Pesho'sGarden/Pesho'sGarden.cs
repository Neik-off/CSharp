using System;
using System.Globalization;
using System.Threading;

class PeshosGarden
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int reservedArea = 0;
        decimal seedPrice = 0;
        int beansArea = 0;
        for (int i = 1; i <= 11; i++)
        {
            if(i%2==0)
            {
                reservedArea += int.Parse(Console.ReadLine());
            }
            else 
            {
                switch (i)
                {
                    case 1: seedPrice = seedPrice + (decimal.Parse(Console.ReadLine())*(decimal)0.5); break;
                    case 3: seedPrice = seedPrice + (decimal.Parse(Console.ReadLine()) * (decimal)0.4); break;
                    case 5: seedPrice = seedPrice + (decimal.Parse(Console.ReadLine()) * (decimal)0.25); break;
                    case 7: seedPrice = seedPrice + (decimal.Parse(Console.ReadLine()) * (decimal)0.6); break;
                    case 9: seedPrice = seedPrice + (decimal.Parse(Console.ReadLine()) * (decimal)0.3); break;
                    case 11: seedPrice = seedPrice + (decimal.Parse(Console.ReadLine()) * (decimal)0.4); break;
                    default:
                        break;
                }
            }
        }
        Console.WriteLine("Total costs: {0:F2}",seedPrice);
        beansArea=250-reservedArea;
        if(beansArea==0)
        {
            Console.WriteLine("No area for beans");
        }
        else if (beansArea > 0)
        {
            Console.WriteLine("Beans area: {0}", beansArea);
        }
        else
        {
            Console.WriteLine("Insufficient area");
        }
    }

    public static System.Globalization.CultureInfo Cultureinfo { get; set; }
}
