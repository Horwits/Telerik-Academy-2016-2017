namespace Shapes.Models
{
    public class Triangle : Shape
    {
        public Triangle()
        {
        }

        public Triangle(double width, double height) 
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            var surface = (this.Height * this.Width) / 2;
            return surface;
        }
    }
}