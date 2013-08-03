using System;

class QuickSort
{
    static int[] arr;
    static void Main()
    {
        arr=new int[]{ 22,2,1,763,412,34,6,6,7,};
        quickSort(0,arr.Length-1);
    }

    static void quickSort(int LO, int HI)
    {
        int I = LO, J = HI, temp;
        int X = arr[(LO + HI) / 2];
        do
        {
            while (arr[I] < X) I++;
            while (arr[J] > X) J--;
            if (I <= J)
            {
                temp = arr[I];
                arr[I] = arr[J];
                arr[J] = temp;
                I++; J--;
            }
        } while (I <= J);
        if (LO < J)
            quickSort(LO, J);
        if (I < HI)
            quickSort(I, HI);
    }
}