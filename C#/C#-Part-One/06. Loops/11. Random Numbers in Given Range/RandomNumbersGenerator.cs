using System;

class RandomNumbersGenerator
{
    static void Main()
    {
        /*Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].*/

        Console.WriteLine("Print n random numbers in the range [min...max].");
        Console.Write("Enter n = ");
        string inputN = Console.ReadLine();
        Console.Write("Enter min = ");
        string inputMin = Console.ReadLine();
        Console.Write("Enter max = ");
        string inputMax = Console.ReadLine();

        int n, min, max;

        bool inputNIsValid = int.TryParse(inputN, out n),
             inputMinIsValid = int.TryParse(inputMin, out min),
             inputMaxIsValid = int.TryParse(inputMax, out max);

        if (inputNIsValid && inputMinIsValid && inputMaxIsValid && (max > min))
        {
            var random = new Random();
            var randomNumbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                var result = random.Next(min, max);
                randomNumbers[i] = result;
            }

            Console.WriteLine(string.Join(", ", randomNumbers));
        }
        else
        {
            string errorMessage = "Invalid number";
            Console.WriteLine(errorMessage);
        }
    }
}
