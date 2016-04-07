using System;

class Sumator
{
    static void Main()
    {
        /*Write a program that reads 5 integer numbers from the console and prints their sum.*/

        bool isValidNumber = true;
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            string input = Console.ReadLine();
            double currentNumber;
            isValidNumber = double.TryParse(input, out currentNumber);

            if (isValidNumber)
            {
                sum += currentNumber;
            }
            else
            {
                isValidNumber = false;
                break;
            }
        }

        string errorMessage = "Ivalid input number.";

        string sumOutput = string.Format("{0}", sum);
        Console.WriteLine("{0}", isValidNumber == true ? sumOutput : errorMessage);
    }
}
