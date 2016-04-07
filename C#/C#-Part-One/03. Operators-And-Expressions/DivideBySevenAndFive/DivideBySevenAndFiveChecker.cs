using System;

class DivideBySevenAndFiveChecker
{
    static void Main()
    {
        /*Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.*/

        double number;
        bool inputIsCorrect = double.TryParse(Console.ReadLine(), out number);

        if (inputIsCorrect)
        {
            bool isDivisibleByFiveAndSeven = (number % 5 == 0) && (number % 7 == 0);
            Console.WriteLine("{0} {1}", isDivisibleByFiveAndSeven.ToString().ToLower(), number);
        }
        else
        {
            Console.WriteLine("Please, enter your number in a valid format!");
        }
    }
}
