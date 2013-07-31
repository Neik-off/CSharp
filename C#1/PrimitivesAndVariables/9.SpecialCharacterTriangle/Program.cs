using System;
using System.Text;

class SpecialCharacter
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char specialChar= '\u00A9';
        for(int i = 0 ; i < 8 ; i++){
            Console.WriteLine();
            for (int k = 0; k < 9; k++)
            {
                Console.Write(specialChar);
            }
        }
    }
}