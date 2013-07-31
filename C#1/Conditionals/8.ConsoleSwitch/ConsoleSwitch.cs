using System;

class ConsoleSwitch
{
    static void Main()
    {
        Console.WriteLine("Enter Value:");
        string request=Console.ReadLine();
        double d;
        bool doubleTry=double.TryParse(request,out d);
        switch(doubleTry){
            case true: d += 1; Console.WriteLine(d); break;
            case false: request += "*"; Console.WriteLine(request); break;
            default :break;
        }
    }
}
