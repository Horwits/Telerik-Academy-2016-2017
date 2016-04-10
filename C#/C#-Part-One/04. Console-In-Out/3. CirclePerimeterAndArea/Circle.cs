using System;

class Circle
{
    static void Main()
    {
        /*Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.*/

        string inputRadius = Console.ReadLine();

        double radius;
        bool inputRadiusIsValid = double.TryParse(inputRadius, out radius);

        if (inputRadiusIsValid)
        {
            double perimeter = CalculatePerimeter(radius);
            double area = CalculateArea(radius);

            Console.WriteLine(
                "{0:F2} {1:F2}",
                perimeter,
                area
                );
        }
        else
        {
            string errorMessage = "Invalid input!";
            Console.WriteLine(errorMessage);
        }
    }

    static double CalculatePerimeter(double radius)
    {
        double perimeter = 2 * Math.PI * radius;
        return perimeter;
    }

    static double CalculateArea(double radius)
    {
        double area = Math.PI * Math.Pow(radius, 2);
        return area;
    }
}
