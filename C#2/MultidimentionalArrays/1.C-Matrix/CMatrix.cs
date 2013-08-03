using System;

class CMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int value = 1;

        //Filling the matrix
        for (int column = 0; column < n; column++)
        {            
            for (int row = n - 1; row >= 0; row--)
            {
                if(matrix[row,column]==0)
                {
                    matrix[row, column] = value;
                    value++;
                }
                Diagonal(matrix,row,column,ref value);
             }
        }

        //Printing The matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        
    }
    static void Diagonal(int[,]matrix,int row,int column,ref int value) 
    {
        while(row<matrix.GetLength(0)-1&&column<matrix.GetLength(1)-1)
        {
            row++;
            column++;

            if (matrix[row, column] == 0)
            {
                matrix[row, column] = value;
                value++;
            }
        }              
    }
}