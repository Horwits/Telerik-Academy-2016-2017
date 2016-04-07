using System;

class InsideCircleAndOutsideRectangle
{
    static void Main()
    {
        /*Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).*/

        double x = 0,
            y = 0,
            circleRadius = 1.5,
            rectangleTop = 1,
            rectangleLeft = -1,
            rectangleWidth = 6,
            rectangleHeight = 2;

        bool inputAIsValid = double.TryParse(Console.ReadLine(), out x),
            inputBIsValid = double.TryParse(Console.ReadLine(), out y);

        if (inputAIsValid && inputBIsValid)
        {
            bool isInsideCircle =
                (Math.Pow(x - 1, 2)) +
                (Math.Pow(y - 1, 2)) <=
                ((circleRadius * circleRadius));

            double rectangleMostRightCorner = rectangleWidth - (Math.Abs(rectangleLeft)),
                rectangleMostDownCorner = (rectangleTop - rectangleHeight);

            bool isOutsideRectangle =
                (((x < rectangleLeft) || (x > rectangleMostRightCorner) ||
                ((y < rectangleMostDownCorner) || (y > rectangleTop))));

            Console.WriteLine
                (
                "{0} {1}",
                isInsideCircle == true ? "inside circle" : "outside circle",
                isOutsideRectangle == true ? "outside rectangle" : "inside rectangle"
                );
        }
        else
        {
            Console.WriteLine("Invalid input numbers.");
        }
    }
}
