using System;

class MajorityMultiple
{
    static void Main()
    {
        int [] arr =new int[5];
        int LMM=0;
        for (int i = 0; i < 5; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int divisible = 1;        
        while(divisible>0)
        {
            int condition = 0;
            for (int i = 0; i < 5; i++)
            {
                if ((divisible % arr[i]) == 0)
                {
                    condition++;
                }
            }
            if(condition>=3)
            {
                LMM = divisible;
                break;
            }
            divisible++;
            
        }

        Console.WriteLine(LMM);
    }
}
