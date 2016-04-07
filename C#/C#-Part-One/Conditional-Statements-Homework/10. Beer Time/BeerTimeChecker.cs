using System;

class BeerTimeChecker
{
    static void Main()
    {
        /*A beer time is after 1:00 PM and before 3:00 AM.
        Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.*/

        Console.WriteLine("Please, enter an hour in format \"hh:mm tt\" (ex. 3:00 AM)");
        string date = Console.ReadLine();

        var parsedDateTime = new DateTime();
        bool dateIsValid = DateTime.TryParse(date, out parsedDateTime);

        string oneBeforeNoonStr = "1:00 PM";
        var onePerMorning = DateTime.Parse(oneBeforeNoonStr);

        string threeAfterNoonStr = "3:00 AM";
        var threeAfterNoon = DateTime.Parse(threeAfterNoonStr);

        bool itIsBeerTime = 
            parsedDateTime.Hour >= onePerMorning.Hour ||
            parsedDateTime.Hour < threeAfterNoon.Hour;
        if (dateIsValid)
        {
            if (itIsBeerTime)
            {
                Console.WriteLine("It's beer time!");
            }
            else
            {
                Console.WriteLine("It's not beer time!");
            }
        }
        else
        {
            Console.WriteLine("Plese, enter a valid input!");
        }
    }
}
