namespace Abstraction.Models
{
    public abstract class Figure
    {
        public abstract double CalcPerimeter();

        public abstract double CalcSurface();

        public override string ToString()
        {
            var template = $"I am a {this.GetType().Name}. My perimeter is {this.CalcPerimeter():f2}. My surface is {this.CalcSurface():f2}.";
            return template;
        }
    }
}
