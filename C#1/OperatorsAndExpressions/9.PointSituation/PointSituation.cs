using System;

class PointSituation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter X Coordinate of your Point:");
        int xCoodinate = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y Coordinate of your Point:");
        int yCoodinate = int.Parse(Console.ReadLine());

        bool withinCircle=false;
        bool withinRectangle=false;

        //Circle check
        if(xCoodinate<=4 && xCoodinate>=-2 && yCoodinate<=4 &&yCoodinate>=-2)
        {
            withinCircle = true;
        }
        //Rectangle check
        if (xCoodinate <= 5 && xCoodinate >= -1 && yCoodinate <= 1 && yCoodinate >= -1)
        {
            withinRectangle = true;
        }
        if (withinCircle && withinRectangle)
        {
            Console.WriteLine("The point is in the figures!");
        }
        else 
        {
            Console.WriteLine("The point isnt in the figures or is only in one of them!");
        }
    }
}
