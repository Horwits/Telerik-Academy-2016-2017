using Abstraction.Validation;

namespace Abstraction.Models
{
    public class Rectangle : Figure
    {
        private double width;
        private double height;

        public Rectangle()
        {
        }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                FigureValuesValidator.ValidateValue(value, nameof(this.width));
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                FigureValuesValidator.ValidateValue(value, nameof(this.height));
                this.height = value;
            }
        }

        public override double CalcPerimeter()
        {
            var perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            var surface = this.Width * this.Height;
            return surface;
        }
    }
}
