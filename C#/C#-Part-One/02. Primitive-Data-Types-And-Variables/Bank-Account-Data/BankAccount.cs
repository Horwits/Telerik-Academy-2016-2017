using System;

class BankAccount
{
    static void Main()
    {
        /*A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
        Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.*/

        string firstName = "Daniel";
        string middleName = "Alexandrov";
        string lastname = "Nikolov";
        string holderName = firstName + " " + middleName + " " + lastname;

        decimal balance;

        string bankName;

        long IBAN;

        string creditCardOne;
        string creditCardTwo;
        string creditCardThree;
    }
}
