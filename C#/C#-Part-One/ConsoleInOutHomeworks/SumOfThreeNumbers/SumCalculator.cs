using System;
using System.Globalization;

class SumCalculator
{
    static void Main()
    {
        CultureInfo culture = CultureInfo.InvariantCulture;

        double a, b, c, sum;

        bool aValueIsValid = double.TryParse(Console.ReadLine(), out a),
        bValueIsValid = double.TryParse(Console.ReadLine(), out b),
        cValueIsValid = double.TryParse(Console.ReadLine(), out c);

        if (aValueIsValid && bValueIsValid && cValueIsValid)
        {
            sum = a + b + c;
            Console.WriteLine("{0}", sum);
        }
        else
        {
            string errorMessage = "Ivalid input.";
            Console.WriteLine(errorMessage);
        }
    }
}
