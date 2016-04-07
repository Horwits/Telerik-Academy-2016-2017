using System;

class Trapezoid
{
    static void Main()
    {
        /*Write an expression that calculates trapezoid's area by given sides a and b and height h.*/

        string[] inputs = new string[3];
        for (int i = 0; i < 3; i++)
        {
            inputs[i] = Console.ReadLine();
        }

        try
        {
            decimal a = DoubleParser(inputs[0]),
            b = DoubleParser(inputs[1]),
            h = DoubleParser(inputs[2]),
            area = (a + b) / 2 * h;

            Console.WriteLine("{0:f7}", area);
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
    }

    static decimal DoubleParser(string input)
    {
        decimal number;
        bool inputIsValid = decimal.TryParse(input, out number);

        if (!inputIsValid)
        {
            throw new FormatException("Invalid input!");
        }

        return number;
    }
}
