using System;

class NandKNumbers
{
    static int[] arr;
    static void Main()
    {
        Console.WriteLine("Enter the N number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the K number:");
        int k = int.Parse(Console.ReadLine());
        arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter (N)numbers for the array:");
            arr[i] = int.Parse(Console.ReadLine());
        }
        quickSort(0,n-1);

        int maxSum = 0;
        Console.WriteLine("The numbers are:");
        for (int i = n-1; i > n-1-k; i--)
        {
            Console.Write(arr[i]+";");
            maxSum+=arr[i];
        }
        Console.WriteLine();
        Console.WriteLine("The max sum of K numbers is {0}!",maxSum);

    }

    static void quickSort (int LO, int HI)
    {
        int I = LO, J = HI, temp;
        int X = arr[(LO+HI)/2];
        do
        {
            while (arr[I] < X) I++;
            while (arr[J] > X) J--;
            if (I<=J)
            {
                temp = arr[I];
                arr[I] = arr[J]; 
			    arr[J] = temp;
                I++; J--;
            }
        }while (I<=J);
        if (LO<J) 
		    quickSort(LO, J);
        if (I<HI) 
		    quickSort(I, HI);
    }

}