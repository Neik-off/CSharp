using System;

namespace NumberSequence
{
    class NumberSequence
    {
        
        static void Main(string[] args)
        {
            for (int i = 2; i < 12 ; i++)
            {
                if ((i % 2) != 0)
                {
                    Console.Write("-");
                }                
                    Console.Write(i);
                if(i<11)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
