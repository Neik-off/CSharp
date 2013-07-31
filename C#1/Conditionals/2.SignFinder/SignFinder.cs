using System;

class SignFinder
{
    static void Main()
    {
        int a = 5, b = 4, c = -2;
        char sign = '-';

        if(a>0)
        {
            if(b>0&&c>0)
            {
                sign = '+';
            }
            else if(b<0&&c<0)
            {
                sign = '+';
            }
        }
        else if(a<0)
        {
            if(b<0&&c>0)
            {
                sign= '+';
            }
            else if(b>0&&c<0)
            {
                sign= '+';
            }
        }
        Console.WriteLine("The sign is '{0}'.",sign);
    }
}
