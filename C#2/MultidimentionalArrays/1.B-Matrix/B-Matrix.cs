using System;

class B_Matrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int value = 1;
        //Filling the matrix
        for (int column = 0; column < matrix.GetLength(0); column++)
        {
            if (column % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[row, column] = value;
                    value++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(1)-1; row >= 0; row--)
                {
                    matrix[row, column] = value;
                    value++;
                }
            }
        }
        //Printing The matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}