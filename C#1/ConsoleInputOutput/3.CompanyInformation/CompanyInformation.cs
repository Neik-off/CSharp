using System;

class CompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Enter the name of the company:");
        String companyName = Console.ReadLine();
        Console.WriteLine("Enter the address of the company:");
        String address = Console.ReadLine();
        Console.WriteLine("Enter the phone number of the company:");
        long phoneNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter the fax number of the company:");
        int faxNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the web site of the company:");
        String webSite = Console.ReadLine();
        Console.WriteLine("Enter the manager of the company:");
        String managerOfTheCompany = Console.ReadLine();
        Console.WriteLine("Enter first and last name of the manager:");
        String managerName = Console.ReadLine();
        Console.WriteLine("Enter the age of the manager:");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter manager's phone number:");
        long managerNumber = long.Parse(Console.ReadLine());

        Console.WriteLine("========================================");
        Console.WriteLine("The company {0}, situated on {1}, which number is-{2} and fax number-{3} has web site:{4} and it's manager is {5}"
                                ,companyName,address,phoneNumber,faxNumber,webSite,managerOfTheCompany);
        Console.WriteLine("The manager {0},who is {1} years old, has phone number:{2}",managerName,age,managerNumber);
        Console.WriteLine("========================================");
        
    }
}
