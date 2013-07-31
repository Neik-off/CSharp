using System;

class TribonacciTriangle
{
    static void Main()
    {
        Int64 firstNumb = Int64.Parse(Console.ReadLine());
        Int64 secondNumb = Int64.Parse(Console.ReadLine());
        Int64 thirdNumb = Int64.Parse(Console.ReadLine());
        int L = int.Parse(Console.ReadLine());
        int arrLenth = 1;

        for (int i = 2; i <= L; i++)
        {
            arrLenth += i;
        }
        Int64[] arr = new Int64 [arrLenth];
        arr[0] = firstNumb;
        arr[1] = secondNumb;
        arr[2] = thirdNumb;

        int index = 0;
        for (int i = 0; i < L; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if(index>2)
                {
                    arr[index] = arr[index - 1] + arr[index - 2] + arr[index - 3];
                }
                if (j == 0)
                {
                    Console.Write(arr[index]);
                    index++;
                }
                else
                {
                    Console.Write(" "+arr[index]);
                    index++;
                }
            }
            Console.WriteLine();
        }
    }
}