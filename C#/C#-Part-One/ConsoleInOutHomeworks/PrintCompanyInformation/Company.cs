using System;

class Company
{
    static void Main()
    {
        /*Problem 2.	Print Company Information
        *	A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
        *	Write a program that reads the information about a company and its manager and prints it back on the console.
        */

        #region Input
        string companyName = Console.ReadLine();

        string companyAddress = Console.ReadLine();

        string phoneNumber = Console.ReadLine();

        string faxNumber = Console.ReadLine();

        string webSite = Console.ReadLine();

        string managerFirstName = Console.ReadLine();

        string managerLastName = Console.ReadLine();

        string managerAge = Console.ReadLine();

        string managerPhone = Console.ReadLine();
        #endregion

        string companyNamePrintString;
        Console.WriteLine(
            companyName != string.Empty ?
            companyNamePrintString = string.Format("{0}", companyName) :
            companyNamePrintString = string.Format("{0}", "(no comany name)")
            );

        string companyAddressPrintString;
        Console.WriteLine(
            companyAddress != string.Empty ?
            companyAddressPrintString = string.Format("Address: {0}", companyAddress) :
            companyAddressPrintString = string.Format("{0}", "(no company address)")
            );

        string companyTelPrintString;
        Console.WriteLine(
            phoneNumber != string.Empty ?
            companyTelPrintString = string.Format("Tel: {0:(+###) ### ## ## ###}", phoneNumber) :
            companyTelPrintString = string.Format("{0}", "(no company phone number)")
            );

        string companyFaxNumberPrintString;
        Console.WriteLine(
            faxNumber != string.Empty ?
            companyFaxNumberPrintString = string.Format("Fax: {0:(+ ###) ## ## ###}", faxNumber) :
            companyFaxNumberPrintString = string.Format("{0}", "(no fax)")
            );

        string webSitePrintString;
        Console.WriteLine(
            webSite != string.Empty ?
            webSitePrintString = string.Format("Web site: {0}", webSite) :
            webSitePrintString = string.Format("{0}", "(no website)")
            );

        string managerFirstNamePrintString,
            managerLastnamePrintString,
            managerAgePrintString,
            managerPhonePrintString;

        Console.WriteLine(
            "Manager: {0} {1} (age: {2}, tel. {3})",
            managerFirstName != string.Empty ?
            managerFirstNamePrintString = string.Format("{0}", managerFirstName) :
            managerFirstNamePrintString = string.Format("{0}", "(no manager first name)"),
            managerLastName != string.Empty ?
            managerLastnamePrintString = string.Format("{0}", managerLastName) :
            managerLastnamePrintString = string.Format("{0}", "(no manager last name)"),
            managerAge != string.Empty ?
            managerAgePrintString = string.Format("{0}", managerAge) :
            managerAgePrintString = string.Format("{0}", "(no manager age)"),
            managerPhone != string.Empty ?
            managerPhonePrintString = string.Format("{0:(+###) # ### ###}", managerPhone) :
            managerPhonePrintString = string.Format("{0}", "(no manager phone)")
            );
    }
}

