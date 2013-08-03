using System;

class LongestSequence
{
    static void Main()
    {
        //int n=int.Parse(Console.ReadLine());
        //int m=int.Parse(Console.ReadLine());
        //string[,] matrix=new string[n,m];
        //Fill(matrix);
        string[,] matrix = 
        {
            {"ha","fi","ho","hi",},
            {"fo","ho","i","k",},
            {"ho","xxx","a","b",},
        };
        int sequenceLenght = 0;
        string sequenceWord=null;
        int currentLength = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                currentLength=Line(matrix,row,column);
                if (currentLength>sequenceLenght)
                {
                    sequenceLenght = currentLength;
                    sequenceWord=matrix[row,column];
                }
                currentLength=Column(matrix, row, column);
                if (currentLength > sequenceLenght)
                {
                    sequenceLenght = currentLength;
                    sequenceWord = matrix[row, column];
                }
                currentLength=RightDiagonal(matrix, row, column);
                if (currentLength > sequenceLenght)
                {
                    sequenceLenght = currentLength;
                    sequenceWord = matrix[row, column];
                }
                currentLength = LeftDiagonal(matrix, row, column);
                if (currentLength > sequenceLenght)
                {
                    sequenceLenght = currentLength;
                    sequenceWord = matrix[row, column];
                }
            }
        }
        for (int i = 0; i < sequenceLenght; i++)
        {
            Console.Write(sequenceWord+", ");
        }
        Console.WriteLine();

    }
    static int Line(string[,]matrix,int row,int column) 
    {
        string word = matrix[row, column];
        int length = 0;
        while (matrix[row,column]==word)
        {
            length++;
            column++;
            if(column==matrix.GetLength(1))
            {
                break;
            }
        }
        return length;
    }
    static int Column(string[,] matrix, int row, int column)
    {
        string word = matrix[row, column];
        int length = 0;
        while (matrix[row, column] == word)
        {
            length++;
            row++;
            if (row == matrix.GetLength(0))
            {
                break;
            }
        }
        return length;
    }
    static int RightDiagonal(string[,] matrix, int row, int column) 
    {
        string word = matrix[row, column];
        int length = 0;
        while (matrix[row, column] == word)
        {
            length++;
            column++;
            row++;
            if (column == matrix.GetLength(1)||row==matrix.GetLength(0))
            {
                break;
            }
        }
        return length;
    }
    static int LeftDiagonal(string[,] matrix, int row, int column)
    {
        string word = matrix[row, column];
        int length = 0;
        while (matrix[row, column] == word)
        {
            length++;
            column--;
            row++;
            if (column == -1 || row == matrix.GetLength(0))
            {
                break;
            }
        }
        return length;
    }
    static void Fill(string[,] matrix) 
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[row, column] = Console.ReadLine();
            }
        }
    }
}