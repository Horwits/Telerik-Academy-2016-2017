using System;

class ThirdDigitIsSevenChecker
{
    static void Main()
    {
        //Write an expression that checks for given integer if its third digit from right-to-left is 7.
        string input = Console.ReadLine();

        if (input.Length > 1)
        {
            int number = int.Parse(input);
            int counter = 1,
                digit = 0;

            while (number > 0)
            {
                if (counter == 3)
                {
                    digit = number % 10;
                }

                counter++;
                number /= 10;
            }

            bool isSeven = digit == 7;
            Console.WriteLine("{0}", isSeven ? "true" : "false " + digit);
        }
        else
        {
            Console.WriteLine("{0}", "false " + 0);
        }
    }
}
