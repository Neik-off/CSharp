using System;

class StringLengthSort
{
    static void Main()
    {
        string[] arr = 
        { "Ivan", "Pesho", "Todor", "Stoqnka", "Dimityr", "Ivanina", "Ana", "Nikola"};
        StringSort(arr,0);
        Console.Write("|");
        foreach (string item in arr)
        {
            Console.Write(item + "|");
        }
        Console.WriteLine();
    }

    static void StringSort(string[] arr,int index)
    {
        string shorter=arr[index];
        int shorterIndex = index;
        for (int i = index+1; i < arr.Length; i++)
        {
            if(arr[i].Length<shorter.Length)
            {
                shorter = arr[i];
                shorterIndex = i;
            }
        }
        if(shorter!=arr[index])
        {
            string temp = arr[index];
            arr[index] = shorter;
            arr[shorterIndex] = temp;
        }
        if (index+1<arr.Length)
        {
            StringSort(arr, index + 1);
        }
    }
}
