using System;

class NumbersToText
{
    static void Main()
    {
        while(true)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Enter Positive Number[0-999]:");
            int numb;
            bool tryParse= int.TryParse(Console.ReadLine(),out numb);

            if(!tryParse)
            {
                Console.WriteLine("Wrong Value!");
                continue;
            }
            if(numb<0 || numb>999)
            {
                Console.WriteLine("Wrong Value!");
                continue;
            }

            int hundreds = numb / 100;
            int tens = (numb - hundreds * 100) / 10;
            int units = (numb - hundreds * 100) - tens * 10;

            //Smaller than 100
            if (numb < 100)
            {
                Console.WriteLine(twoDigit(tens, units));
            }
            //Bigger than 100
            else
            {
                if (tens == 0 && units == 0)
                {
                    Console.WriteLine(TextEqualation(hundreds) + " hundred ");
                }
                else
                {
                    Console.WriteLine(TextEqualation(hundreds) + " hundred and " + twoDigit(tens, units));
                }
            }
        }

    }

    public static string TextEqualation(int number) 
    {
        string numberToString=null;
        switch(number)
        {
            case 0: numberToString="Zero"; break;
            case 1: numberToString="One"; break;
            case 2: numberToString="Two"; break;
            case 3: numberToString="Tree"; break;
            case 4: numberToString="Four"; break;
            case 5: numberToString="Five"; break;
            case 6: numberToString="Six"; break;
            case 7: numberToString="Seven"; break;
            case 8: numberToString="Eight"; break;
            case 9: numberToString="Nine"; break;
            case 10: numberToString = "Ten"; break;
            case 11: numberToString = "Eleven"; break;
            case 12: numberToString = "Twelve"; break;
            case 13: numberToString = "Thirteen"; break;
            case 15: numberToString = "Fifteen"; break;
            case 18: numberToString = "Eighteen"; break;
            default: break;
        }
        return numberToString;
    }
    //
    public static string twoDigit(int tens, int units)
    {
        string Text="";
        //Smaller than 20
        if (tens < 2)
        {
            if(tens==0)
            {
                Text =TextEqualation(units);
            }
            else if (units < 4 || units == 8 || units == 5)
            {
                Text = TextEqualation(int.Parse(tens + "" + units));
            }
            else
            {
                Text = TextEqualation(units) + "teen";
            }

        }
        //Bigger than 20
        else if (tens >= 2)
        {
            if (tens == 2)
            {
                if (units == 0)
                {
                    Text="Twenty ";
                }
                else
                {
                    Text="Twenty-" + TextEqualation(units);
                }
            }
            else if (tens == 3)
            {
                if (units == 0)
                {
                    Text="Thirty ";
                }
                else
                {
                    Text="Thirty-" + TextEqualation(units);
                }

            }
            else if (tens == 5)
            {
                if (units == 0)
                {
                    Text="Fifty";
                }
                else
                {
                    Text="Fifty-" + TextEqualation(units);
                }
            }
            else if (tens == 8)
            {
                if (units == 0)
                {
                    Text="Eighty";
                }
                else
                {
                    Text="Eighty-" + TextEqualation(units);
                }
            }
            else
            {
                if (units == 0)
                {
                    Text=TextEqualation(tens) + "ty ";
                }
                else
                {
                    Text=TextEqualation(tens) + "ty-" + TextEqualation(units);
                }
            }

        }
        return Text;
    }

}