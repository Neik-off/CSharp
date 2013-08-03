using System;

class DMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int value = 1;
        string direction = "Down";
        int row = 0;
        int column = 0;
        //Filling the matrix
        while (value<=n*n)
        {
            matrix[row, column] = value;
            value++;
            if(direction=="Down")
            {
                if (row+1>n-1||matrix[row+1,column]!=0)
                {
                    direction = "Right";
                }
            }
            else if (direction == "Right")
            {
                if (column + 1 > n - 1 || matrix[row , column+1] != 0)
                {
                    direction = "Up";
                }
            }
            if (direction == "Up")
            {
                if (row-1 < 0 || matrix[row-1 , column] != 0)
                {
                    direction = "Left";
                }
            }
            if (direction == "Left")
            {
                if (column-1 < 0 || matrix[row, column-1] != 0)
                {
                    direction = "Down";
                }
            }
            switch (direction)
            {
                case "Down":
                    row++;

                    break;

                case "Right":
                    column++;

                    break;

                case "Up":
                    row--; 
                    break;

                case "Left":
                    column--;
                    break;

                default:
                    break;                    
            }
        }

        //Printing The matrix
        for (int i = 0; i < n; i++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,2} ", matrix[i, col]);
            }
            Console.WriteLine();
        }

    }
}