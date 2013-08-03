using System;

class MatrixClass
{
    static void Main()
    {
        int x=5, y=5;
        Matrix A = new Matrix(x,y);
        Matrix B = new Matrix(x, y);
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                A[i, j] = i + j;
                B[i, j] = i * j;
            }
        }
        Console.WriteLine(A.ToString());
        Console.WriteLine(B.ToString());
        Matrix C = A * B;
        Console.WriteLine(C.ToString());

    }
}

class Matrix 
{
    public int rows;
    public int columns;
    private int[,] matrix;

    public Matrix(int x,int y) 
    {
        rows = x;
        columns = y;
        matrix = new int[rows, columns];
    }
    public int this[int x,int y]
    {
        get {return matrix[x,y];}
        set { matrix[x, y] = value; }
    }
    //Add Method
    public static Matrix operator +(Matrix A,Matrix B)
    {
        Matrix C = new Matrix(A.rows,B.columns);

        for (int i = 0; i < C.rows; i++)
        {
            for (int j = 0; j < C.columns; j++)
            {
                C[i, j] = A[i, j] + B[i, j];
            }
        }
        return C;

    }
    //Subrtaction
    public static Matrix operator -(Matrix A, Matrix B)
    {
        Matrix C = new Matrix(A.rows, B.columns);

        for (int i = 0; i < C.rows; i++)
            for (int j = 0; j < C.columns; j++)
                C[i, j] = A[i, j] - B[i, j];

        return C;
    }
    //Multiply Method
    public static Matrix operator *(Matrix A, Matrix B) 
    {
        if (A.columns!=B.rows)
        {
            Console.WriteLine("Wront arguments! The number of columns of the first matrix have to equal the number of rows of the second one!");
            return null;
        }
        Matrix C = new Matrix(A.rows,B.columns);

        for (int i = 0; i < C.rows; i++)
        {
            for (int j = 0; j < C.columns; j++)
            {
                for (int k= 0; k < B.rows; k++)
			    {
                    C[i, j] += A[i, k] * B[k, j];
			    }                
            }
        }
        return C;
    }
    //Print Method
    public override string ToString()
    {
        string str=null;

        for (int i = 0; i < this.rows; i++)
        {
            for (int j = 0; j < this.columns; j++)
            {
                str += Convert.ToString(this.matrix[i,j]+(j!=this.columns-1? " ": "\n"));
            }
        }
        return str;
    }
    
}