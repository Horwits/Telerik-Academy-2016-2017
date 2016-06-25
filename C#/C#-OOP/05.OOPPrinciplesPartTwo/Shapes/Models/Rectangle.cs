namespace Shapes.Models
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
        }

        public Rectangle(double width, double height) 
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            var surface = this.Height * this.Width;
            return surface;
        }
    }
}