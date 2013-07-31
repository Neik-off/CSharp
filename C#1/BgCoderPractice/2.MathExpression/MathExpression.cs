using System;
using System.Globalization;
using System.Threading;

class MathExpression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double N = double.Parse(Console.ReadLine());
        double M = double.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());

        double sin = Math.Sin((int)M % 180);
        double numerator = (Math.Pow(N, 2) + (1.0 / (M * P)) + 1337.0);
        double denomerator = (N - 128.523123123 * P);
        double equalation = numerator / denomerator + sin;
        Console.WriteLine("{0:F6}",equalation);
    }
}