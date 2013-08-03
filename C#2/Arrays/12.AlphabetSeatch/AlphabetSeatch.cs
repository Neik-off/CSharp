using System;

class AlphabetSeatch
{
    static char[] alphabeth = new char[26];
    static void Main()
    {
        
        for (int i = 0, letter=97; i < 26; i++, letter++)
        {
            alphabeth[i]=(char)letter;
        }

        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine("The index of letter-\"{0}\" is: {1}.", word[i] ,binarySearch(0, alphabeth.Length, word[i]));
        }
    }

    static int binarySearch(int lo, int hi, char x)
    {
        int middleIndex = lo + ((hi - lo) / 2);
        int middle = alphabeth[middleIndex];

        if (lo > hi)
        {
            return -1;
        }
        else if (x > middle)
        {
            return binarySearch(middleIndex + 1, hi, x);
        }
        else if (x < middle)
        {
            return binarySearch(lo, middleIndex - 1, x);
        }
        else
        {
            return middleIndex;
        }
    }
}