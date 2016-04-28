using System;

class SquareRoot
{
    public static double CalculateSquareRootOfInteger(string inputNumber)
    {
        int number = 0;
        bool isNumberValid = int.TryParse(inputNumber, out number);

        double squareRoot = 0;
        if (isNumberValid)
        {
            squareRoot = Math.Sqrt(number);
        }
        else
        {
            if (!isNumberValid)
            {
                throw new ArgumentException("Invalid number");
            }

            if (number > 0)
            {
                throw new FormatException("Invalid number");
            }
        }

        return squareRoot;
    }

    static void Main()
    {
        try
        {
            double sqrt = CalculateSquareRootOfInteger(Console.ReadLine());
            Console.WriteLine(sqrt);
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
            Console.WriteLine("Goodbye");
        }
    }
}
