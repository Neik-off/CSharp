using System;
namespace StringIntroduction
{
    class StringIntroduction
    {
        static void Main(string[] args)
        {
            string first="Hello",second="World",third;
            object obj;
            obj = (Object)first + " " + (Object)second;
            third = (String)obj;
            Console.WriteLine(third);
        }
    }
}
