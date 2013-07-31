using System;

class StringTest
{
    static void Main(string[] args)
    {

        string withQuotations = "The \"use\" of quotations causes difficulties";
        string withoutQuotations = "The use of quotations causes difficulties.";
            
        Console.WriteLine(withQuotations + "\n" + withoutQuotations);
    }
}

