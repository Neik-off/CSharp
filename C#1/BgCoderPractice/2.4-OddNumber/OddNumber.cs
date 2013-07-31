using System;

class OddNumber
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        long currentNumber, sum = 0;

        for (int i = 0; i < N; i++)
        {
            currentNumber = long.Parse(Console.ReadLine());
            sum ^= currentNumber;
        }

        Console.WriteLine(sum);
    }
}
//using System;

//class OddNumber
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        long [] arr=new long[(n+1)/2];
//        int[] count = new int[(n + 1) / 2];
//        long readerNumber = 0;
//        int freeCell=0;
//        for (int i = 0; i < n; i++)
//        {
//            bool match = false;
//            readerNumber = long.Parse(Console.ReadLine());
//            for (int j = 0; j < freeCell; j++)
//            {
//                if (readerNumber == arr[j])
//                {
//                    count[j]++;
//                    match = true;
//                    break;                   
//                }

//            }
//            if(!match)
//            {
//                arr[freeCell] = readerNumber;
//                count[freeCell]++;
//                freeCell++;
//            }
//        }
//        long oddNumber=0;
//        for (int i = 0; i < n; i++)
//        {
//            if (count[i] % 2 != 0)
//            {
//                oddNumber = arr[i];
//                break;
//            }
//        }


//        Console.WriteLine(oddNumber);

//    }
//}