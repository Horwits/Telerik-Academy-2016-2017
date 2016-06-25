namespace Shapes.Models
{
    using Validation;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape()
            : this(0, 0)
        {
        }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                Validation.ValidateDouble(value);
                this.width = value;
            }
        }

        public virtual double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                Validation.ValidateDouble(value);
                this.height = value;
            }
        }

        public abstract double CalculateSurface();

        public override string ToString()
        {
            return this.GetType().Name + ":\n\r" + "width " + this.Width + " height: " + this.Height;
        }
    }
}