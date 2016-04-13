using System;

class Program
{
    static void Main()
    {
        /*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        If the variable is int or double, the program increases it by one.
        If the variable is a string, the program appends * at the end.
        Print the result at the console. Use switch statement.*/

        string userChoose = Console.ReadLine();

        bool inputIsValid = true;
        switch (userChoose)
        {
            case "integer":
                string input = Console.ReadLine();

                int userInt;
                inputIsValid = int.TryParse(input, out userInt);

                double result = 1;
                if (inputIsValid)
                {
                    Console.WriteLine("{0}", result += userInt);
                }

                break;

            case "real":
                input = Console.ReadLine();

                double userDouble;
                inputIsValid = double.TryParse(input, out userDouble);

                result = 1;
                if (inputIsValid)
                {
                    Console.WriteLine("{0:f2}", result += userDouble);
                }

                break;

            case "text":
                input = Console.ReadLine();
                Console.WriteLine("{0}", input + "*");
                break;
        }
    }
}
