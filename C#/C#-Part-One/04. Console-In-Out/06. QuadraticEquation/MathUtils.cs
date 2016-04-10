using System;

class MathUtils
{
    static void SolveQuadraticEquation(double a, double b, double c)
    {
        double sqrtPart = b * b - 4 * a * c;
        double x, x1, x2;
        if (sqrtPart > 0)
        {
            x1 = (-b - Math.Sqrt(sqrtPart)) / (2 * a);
            x2 = (-b + Math.Sqrt(sqrtPart)) / (2 * a);
            Console.WriteLine("{0:f2} {1:f2}", x1, x2);
        }
        else if (sqrtPart < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            x = (-b + Math.Sqrt(sqrtPart)) / (2 * a);
            Console.WriteLine("{0:f2}", x);
        }
    }

    static void Main()
    {
        /*Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).*/

        string inputA = Console.ReadLine();

        string inputB = Console.ReadLine();

        string inputC = Console.ReadLine();

        double a;
        bool inputAIsValid = double.TryParse(inputA, out a);

        double b;
        bool inputBIsValid = double.TryParse(inputB, out b);

        double c;
        bool inputCIsValid = double.TryParse(inputC, out c);

        if (
            inputAIsValid &&
            inputBIsValid &&
            inputCIsValid
            )
        {
            SolveQuadraticEquation(a, b, c);
        }
        else
        {
            string errorMessage = "Invalid input number";
            Console.WriteLine(errorMessage);
        }
    }
}
