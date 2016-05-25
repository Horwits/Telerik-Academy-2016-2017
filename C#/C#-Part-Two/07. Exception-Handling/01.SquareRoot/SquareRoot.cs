using System;

class SquareRoot
{
    public static double CalculateSquareRootOfInteger(string inputNumber)
    {
        double number = 0;
        bool isNumberValid = double.TryParse(inputNumber, out number);

        double squareRoot = 0;
        if (isNumberValid)
        {
            squareRoot = Math.Sqrt(number);
        }
        else
        {
            if (!isNumberValid)
            {
                throw new FormatException("Invalid number");
            }

            if (number < 0)
            {
                throw new FormatException("Invalid number");
            }
        }

        if (squareRoot.ToString() == "NaN")
        {
            throw new ArgumentException("Invalid number");
        }

        return squareRoot;
    }

    static void Main()
    {
        try
        {
            var sqrt = CalculateSquareRootOfInteger(Console.ReadLine());
            Console.WriteLine("{0:f3}", sqrt);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
