using System;

class PointInCircleChecker
{
    static void Main()
    {
        //Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

        double x = 0,
            y = 0,
            circleRadius = 2;

        bool inputAIsValid = double.TryParse(Console.ReadLine(), out x),
            inputBIsValid = double.TryParse(Console.ReadLine(), out y);

        if (inputAIsValid && inputBIsValid)
        {
            var xPowTwo = Math.Pow(x, 2);
            var yPowTwo = Math.Pow(y, 2);
            var radiusPowTwo = Math.Pow(circleRadius, 2);
            var distance = Math.Sqrt(xPowTwo + yPowTwo);
            bool isInsideCircle = distance <= circleRadius * circleRadius;

            //Console.WriteLine("{0}", isInsideCircle.ToString().ToLower());
            Console.WriteLine("{0} {1:f2}", isInsideCircle == true ? "yes" : "no", distance);
        }
        else
        {
            Console.WriteLine("Invalid input numbers.");
        }
    }
}
