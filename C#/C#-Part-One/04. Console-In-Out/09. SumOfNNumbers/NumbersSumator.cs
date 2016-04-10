using System;

class NumbersSumator
{
    static void Main()
    {
        /*Write a program that enters a number N and after that enters more N numbers and calculates and prints their sum.
        Note: You may need to use a for-loop.*/

        string inputLength = Console.ReadLine();

        int n;
        bool inputLenghtIsValid = int.TryParse(inputLength, out n);

        string errorMessage = "Invalid number!";

        if (inputLenghtIsValid)
        {
            double sum = 0;

            //Console.WriteLine("Enter {0} more to see the Sum: ", n);

            bool invalidValue = false;

            for (int i = 0; i < n; i++)
            {
                string nextNumberInput = Console.ReadLine();

                double nextNumber;
                bool nextNumberInputIsValid = double.TryParse(nextNumberInput, out nextNumber);

                if (!nextNumberInputIsValid)
                {
                    invalidValue = true;
                    break;
                }

                sum += nextNumber;
            }

            if (invalidValue)
            {
                Console.WriteLine(errorMessage);
            }
            else
            {
                Console.WriteLine("{0}", sum);
            }
        }
        else
        {
            Console.WriteLine(errorMessage);
        }
    }
}
