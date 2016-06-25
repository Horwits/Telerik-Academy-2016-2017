namespace Shapes.Models
{
    using System;

    public class Square : Shape
    {
        public Square()
        {
        }

        public Square(double width, double height) 
            : base(width, height)
        {
            if (width != height)
            {
                throw new FormatException("Values cannot be different from each other.");
            }
        }

        public override double CalculateSurface()
        {
            var surface = this.Height * this.Width;
            return surface;
        }
    }
}