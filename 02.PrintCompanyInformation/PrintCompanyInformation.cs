using System;
class PrintCompanyInformation
{
    // A company has name, address, phone number, fax number, web site and manager.
    // The manager has first name, last name, age and a phone number.
    // Write a program that reads the information about company and its manager and prints it
    // back on the console.
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        ulong phoneNumber = ulong.Parse(Console.ReadLine());
        Console.Write("Enter company fax number: ");
        object faxNumber = Console.ReadLine();
        Console.Write("Enter website: ");
        string site = Console.ReadLine();
        Console.Write("Enter manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter age: ");
        short age = short.Parse(Console.ReadLine());
        Console.Write("Enter manager phone number: ");
        ulong managerPhoneNumber = ulong.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}" +
                          "\nWeb site: {4}\nManager: {5} {6}(age: {7}, tel. {8})",
                          companyName, companyAddress, phoneNumber, faxNumber, site,
                          firstName, lastName, age, managerPhoneNumber);
    }
}