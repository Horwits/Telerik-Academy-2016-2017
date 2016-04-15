using System;

class Number
{
    static void Main()
    {
        string errorMessage = "Invalid input";

        string inputN = Console.ReadLine();

        int n;
        bool nIsValid = int.TryParse(inputN, out n);
        if (nIsValid)
        {
            double[] inputNumbers = new double[n];
            bool inputNumberIsValid = false;
            for (int i = 0; i < n; i++)
            {
                string inputNumber = Console.ReadLine();
                inputNumberIsValid = double.TryParse(inputNumber, out inputNumbers[i]);
                if (!inputNumberIsValid)
                {
                    break;
                }
            }

            double min = inputNumbers[0];
            for (int i = 1; i < n; i++)
            {
                min = Math.Min(min, inputNumbers[i]);
            }

            double max = inputNumbers[0];
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
                Console.WriteLine("min={0:f2}", min);
                Console.WriteLine("max={0:f2}", max);
                Console.WriteLine("sum={0:f2}", sum);

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
