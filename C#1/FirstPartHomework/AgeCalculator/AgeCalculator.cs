using System;

namespace AgeCalculator
{   
    class AgeCalculator
    {
        private static int age;
        static void Main(string[] args)
        {
            age=int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years: "+(age+10));
        }
    }
}
