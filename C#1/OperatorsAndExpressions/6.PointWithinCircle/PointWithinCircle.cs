using System;

class PointWithinCircle
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter X Coordinate of your Point:");
            int xCoodinate = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y Coordinate of your Point:");
            int yCoodinate = int.Parse(Console.ReadLine());

            if (xCoodinate <= 5 && xCoodinate >= -5 && yCoodinate <= 5 && yCoodinate >= -5)
            {
                Console.WriteLine("The point is in the circle");
            }
            else
            {
                Console.WriteLine("The point isnt in the circle");
            }
        }
    }
}

