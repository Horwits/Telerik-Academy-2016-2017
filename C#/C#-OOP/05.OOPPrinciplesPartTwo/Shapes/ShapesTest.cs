namespace Shapes
{
    using System;
    using System.Collections.Generic;

    using Shapes.Models;

    internal class ShapesTest
    {
        internal static void Main(string[] args)
        {
            var square = new Square(12, 12);
            //// var square = new Square(12, 13); // uncomment to see the validation

            var shapes = new List<Shape>();
            shapes.Add(square);
            shapes.Add(new Triangle(11, 15));
            shapes.Add(new Rectangle(0.1, 11.5));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Working list: ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(string.Join("\n\r", shapes));

            Console.Write(Environment.NewLine);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Calculate surface test: ");

            Console.ForegroundColor = ConsoleColor.White;
            foreach (var shape in shapes)
            {
                Console.WriteLine("{0} surface - {1}", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
