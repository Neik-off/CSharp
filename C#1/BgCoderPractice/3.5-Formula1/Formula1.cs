using System;

class Formula1
{
    static void Main()
    {
        int[,] grid = new int[8, 8];
        int number;
        string direction = "South";
        int row = 0, column = 0;
        int path = 1;
        int corners = 0;
        string previousDirection = "South";
        bool enter=true;
        int enterRow = 0;
        bool go = false;
        while (true)
        {
            if(enter)
            {
                number = int.Parse(Console.ReadLine());
                for (int j = 0; j < 8; j++)
                {
                    int bit = (number >> j) & 1;
                    grid[enterRow, j] = bit;
                }
                
                if (enterRow==1)
                {
                    go = true; 
                }
                else if(enterRow==7)
                {
                    enter = false;
                }
                enterRow++;
            }
            if (go)
            {
                if (direction == "South")
                {
                    if (row < 7 && grid[row + 1, column] == 0)
                    {
                        row += 1;
                        path++;
                    }
                    else
                    {
                        if (column < 7 && grid[row, column + 1] == 1)
                        {
                            Console.WriteLine("No {0}", path);
                            break;
                        }
                        previousDirection = direction;
                        direction = "West";
                        corners++;
                    }
                }
                else if (direction == "West")
                {
                    if (column < 7 && grid[row, column + 1] == 0)
                    {
                        column += 1;
                        path++;
                    }
                    else
                    {
                        if (previousDirection == "North")
                        {
                            if (row < 7 && grid[row + 1, column] == 1)
                            {
                                Console.WriteLine("No {0}", path);
                                break;
                            }
                            direction = "South";
                            corners++;
                        }
                        else if (previousDirection == "South")
                        {
                            if (row > 0 && grid[row - 1, column] == 1)
                            {
                                Console.WriteLine("No {0}", path);
                                break;
                            }
                            direction = "North";
                            corners++;
                        }
                        else
                        {
                            Console.WriteLine("No {0}", path);
                            break;
                        }
                    }
                }
                else if (direction == "North")
                {
                    if (row > 0 && grid[row - 1, column] == 0)
                    {
                        row -= 1;
                        path++;
                    }
                    else
                    {
                        if (column < 7 && grid[row, column + 1] == 1)
                        {
                            Console.WriteLine("No {0}", path);
                            break;
                        }
                        previousDirection = direction;
                        direction = "West";
                        corners++;
                    }
                }
                if (row == 7 && column == 7)
                {
                    Console.WriteLine("{0} {1}", path, corners);
                    break;
                }
            }
        }
    }
}