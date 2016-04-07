using System;

class Number
{
    static void Main()
    {
        /*Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
            The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
            The output is like in the examples below.*/

        string errorMessage = "Invalid input";

        string inputN = Console.ReadLine();

        int n;
        bool nIsValid = int.TryParse(inputN, out n);
        if (nIsValid)
        {
            int[] inputNumbers = new int[n];
            bool inputNumberIsValid = false;
            for (int i = 0; i < n; i++)
            {
                string inputNumber = Console.ReadLine();
                inputNumberIsValid = int.TryParse(inputNumber, out inputNumbers[i]);
                if (!inputNumberIsValid)
                {
                    break;
                }
            }

            int min = inputNumbers[0];
            for (int i = 1; i < n; i++)
            {
                min = Math.Min(min, inputNumbers[i]);
            }

            int max = inputNumbers[0];
            for (int i = 1; i < n; i++)
            {
                max = Math.Max(max, inputNumbers[i]);
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += inputNumbers[i];
            }

            if (inputNumberIsValid)
            {
                Console.WriteLine("min={0}", min);
                Console.WriteLine("max={0}", max);
                Console.WriteLine("sum={0}", sum);

                double average = sum / n;
                Console.WriteLine("avg={0:f2}", average);
            }
            else
            {
                Console.WriteLine(errorMessage);
            }
        }
        else
        {
            Console.WriteLine(errorMessage);
        }
    }
}
