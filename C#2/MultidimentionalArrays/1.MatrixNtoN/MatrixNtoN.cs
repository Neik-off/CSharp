using System;

class MatrixNtoN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix=new int[n,n];
        int value = 1;
        //Filling the matrix
        for (int column = 0; column < matrix.GetLength(0); column++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                matrix[row,column]=value;
                value++;
            }
        }
        //Printing The matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,2} ",matrix[row,col]);
            }
            Console.WriteLine();
        }
    }
}