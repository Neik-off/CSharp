using System;
using System.Text;

class SpecialCharacterTriangle

{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char specialChar= '\u00A9';
        for(int i = 0 ; i < 9 ; i++)
            {
            Console.WriteLine();
            for (int k = 0; k < i; k++)
            {
                Console.Write(specialChar);
            }            
        }
        Console.WriteLine();
    }
}