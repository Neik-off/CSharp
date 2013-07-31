using System;

class SubsetSums
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        long [] arr=new long[N+1];

        for (int i = 1; i <= N; i++)
        {
            arr[i] = long.Parse(Console.ReadLine());
        }
        int combinationNumber = (int)Math.Pow(2, N) - 1;
        int subsetCount = 0;
        for (int i = 1; i <= combinationNumber; i++)
        {
            long currentSum=0;
            for (int j = 1; j <= N; j++)
            {
                if(((i>>(j-1))&1)==1)
                {
                    currentSum += arr[j];
                }
            }
            if(currentSum==s)
            {
                subsetCount++;
            }
        }
        Console.WriteLine(subsetCount);
    }
}