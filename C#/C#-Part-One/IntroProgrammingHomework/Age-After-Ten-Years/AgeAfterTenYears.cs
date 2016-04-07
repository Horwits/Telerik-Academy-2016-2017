using System;
using System.Globalization;
using System.Threading;

class AgeAfterTenYearsCalculator
{
    static void Main()
    {
        /*Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.*/
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        var inputDate = Console.ReadLine();

        var myBirthDate = DateTime.Parse(inputDate);

        var currentDate = DateTime.Now;

        var myAgeDate = currentDate.Date - myBirthDate.Date;
        var myAge = (myAgeDate.Days / 365);

        var myAgeAfterTenYears = myAge + 10;

        Console.WriteLine(myAge);
        Console.WriteLine(myAgeAfterTenYears);
    }
}
