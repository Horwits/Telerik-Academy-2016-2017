using System;

class RandomNumbersGenerator
{
    static void Main()
    {
        /*Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.*/

        Console.WriteLine("Prints the numbers 1, 2, …, n in random order: ");
        Console.Write("n = ");
        string input = Console.ReadLine();

        int n;
        bool inputIsValid = int.TryParse(input, out n);
        if (inputIsValid)
        {
            var random = new Random();
            var randomNumbers = new int[n];
            for (int i = 1, j = 0; i <= n; i++, j++)
            {
                var result = random.Next(i, n);
                randomNumbers[j] = result;
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