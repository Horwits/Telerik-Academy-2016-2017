using System;

class Rectangle
{
    static void Main()
    {
        //Write an expression that calculates rectangle’s perimeter and area by given width and height.

        double width;
        bool widthIsCorrect = double.TryParse(Console.ReadLine(), out width);

        double height;
        bool heightIsCorrect = double.TryParse(Console.ReadLine(), out height);

        if (widthIsCorrect && heightIsCorrect)
        {
            double rectangleArea = width * height;
            double rectanglePerimeter = (width * 2) + (height * 2);

            Console.WriteLine("{0:f2} {1:f2}", rectangleArea, rectanglePerimeter);
        }
        else
        {
            throw new FormatException("Please, enter your numbers in a valid format!");
        }
    }
}
