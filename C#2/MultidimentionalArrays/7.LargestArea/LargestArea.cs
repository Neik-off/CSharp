using System;
using System.Collections;

class LargestArea
{
    static void Main()
    {
        int[,] matrix =
        {
            {1,3,2,2,2,4},
            {3,3,3,2,4,4},
            {4,3,1,2,3,3},
            {4,3,1,3,3,1},
            {4,3,3,3,1,1}
        };
        bool[,] visited=new bool[matrix.GetLength(0),matrix.GetLength(1)];

        int largestArea = 0;
        Stack stack=new Stack();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {

                if (visited[i, j])
                {
                    continue;
                }
                ArrayElement current = new ArrayElement(i,j);
                stack.Push(current);
                int currentArea=0;
                int value = matrix[i, j];
                while (stack.Count != 0)
                {
                    ArrayElement peek = (ArrayElement)stack.Peek();
                    int currentRow=peek.row, currentCol=peek.column;
                    currentArea++;
                    visited[currentRow, currentCol] = true;
                    stack.Pop();
                    //UpperLeft Diagonal
                    if (currentRow - 1 >= 0 && currentCol - 1 >= 0 && !visited[currentRow - 1, currentCol - 1] && matrix[currentRow - 1, currentCol - 1] == value)
                    {
                        stack.Push(new ArrayElement(currentRow - 1, currentCol - 1));
                        visited[currentRow - 1, currentCol - 1] = true;
                    }
                    //Upper
                    if (currentRow - 1 >= 0 && !visited[currentRow - 1, currentCol] && matrix[currentRow - 1, currentCol] == value)
                    {
                        stack.Push(new ArrayElement(currentRow - 1, currentCol));
                        visited[currentRow - 1, currentCol] = true;
                    }
                    //UpperRight Diagonal
                    if (currentRow - 1 >= 0 && currentCol + 1 <= 5 && !visited[currentRow - 1, currentCol + 1] && matrix[currentRow - 1, currentCol + 1] == value)
                    {
                        stack.Push(new ArrayElement(currentRow - 1, currentCol + 1));
                        visited[currentRow - 1, currentCol + 1] = true;
                    }
                    //Left
                    if (currentCol - 1 >= 0 && !visited[currentRow, currentCol - 1] && matrix[currentRow, currentCol - 1] == value)
                    {
                        stack.Push(new ArrayElement(currentRow, currentCol - 1));
                        visited[currentRow , currentCol - 1] = true;
                    }
                    //Right
                    if (currentCol + 1 <= 5 && !visited[currentRow, currentCol + 1] && matrix[currentRow, currentCol + 1] == value)
                    {
                        stack.Push(new ArrayElement(currentRow, currentCol + 1));
                        visited[currentRow , currentCol + 1] = true;
                    }
                    //LowerLeft Diagonal
                    if (currentRow + 1 <= 4 && currentCol - 1 >= 0 && !visited[currentRow + 1, currentCol - 1] && matrix[currentRow + 1, currentCol - 1] == value)
                    {
                        stack.Push(new ArrayElement(currentRow + 1, currentCol - 1));
                        visited[currentRow + 1, currentCol - 1] = true;
                    }
                    //Lower
                    if (currentRow + 1 <= 4 && !visited[currentRow + 1, currentCol] && matrix[currentRow + 1, currentCol] == value)
                    {
                        stack.Push(new ArrayElement(currentRow + 1, currentCol));
                        visited[currentRow + 1, currentCol] = true;
                    }
                    //LowerRight Diagonal
                    if (currentRow + 1 <= 4 && currentCol + 1 <= 5 && !visited[currentRow + 1, currentCol + 1] && matrix[currentRow + 1, currentCol + 1] == value)
                    {
                        stack.Push(new ArrayElement(currentRow + 1, currentCol + 1));
                        visited[currentRow + 1, currentCol + 1] = true;
                    }

                    

                }
                if (currentArea>largestArea)
                {
                    largestArea = currentArea;
                }
            }
        }
        Console.WriteLine("The largest Area is {0}!" ,largestArea);
    }
    class ArrayElement
    {
        public int row, column;
        public ArrayElement(int i,int j) 
        {
            row=i;
            column=j;
        }
    }
}