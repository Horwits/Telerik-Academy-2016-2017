using System;
using Abstraction.Validation;

namespace Abstraction.Models
{
    public class Circle : Figure
    {
        private double radius;

        public Circle()
        {
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                FigureValuesValidator.ValidateValue(value, nameof(this.radius));
                this.radius = value;
            }
        }

        public override double CalcPerimeter()
        {
            var perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            var surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
