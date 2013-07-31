using System;

class AsciiTable
{
    static void Main()
    {
        char ch;
        for (int i = 0; i < 255; i++)
        {
            ch = (char)i;
            Console.WriteLine("Number:"+i+"Character:"+ch);
        }
    }
}

