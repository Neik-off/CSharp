using System;

class SumSquare
{
    static void Main()
    {
        //int n = int.Parse(Console.ReadLine());
        //int m = int.Parse(Console.ReadLine());
        //int[,] matrix = new int[n, m];
        //Fill(matrix);
        int[,] matrix = 
        {
            {9,9,1,1,1,2},
            {1,1,1,1,1,1},
            {1,1,1,1,1,1},
            {1,1,9,1,1,1},

        };
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestColumn = 0;

        

        for (int row = 0; row < matrix.GetLength(0)-2; row++)
        {
            int currentSum = 0;
            for (int column = 0; column < matrix.GetLength(1)-2; column++)
            {
                currentSum = Sum(matrix,row,column);
                if (currentSum>bestSum)
                {
                    bestSum = currentSum;
                    bestRow = row;
                    bestColumn = column;
                }
            }
        }
        for (int i = bestRow; i < bestRow + 3; i++)
        {
            for (int j = bestColumn; j < bestColumn + 3; j++)
            {
                Console.Write(matrix[i,j]+" ");
            }
            Console.WriteLine();
            
        }
        Console.WriteLine("Best Sum = {0}!", bestSum);
    }
    static int Sum(int[,] matrix,int row,int column) 
    {
        int sum = 0;
        for (int i = row; i < row+3; i++)
        {
            for (int j = column; j < column+3; j++)
            {
                sum += matrix[i, j];
            }
        }
        return sum;
    }
    static void Fill(int[,]matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[row, column] = int.Parse(Console.ReadLine());
            }
        }
    }
}