using System;

class RectanglesArea
{
    static void Main()
    {
        Console.WriteLine("Enter width:");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter height:");
        int height = int.Parse(Console.ReadLine());
        //Area calculating
        Console.WriteLine("Your Rectangle has Area: "+ ( height * width ) );
    }
}

