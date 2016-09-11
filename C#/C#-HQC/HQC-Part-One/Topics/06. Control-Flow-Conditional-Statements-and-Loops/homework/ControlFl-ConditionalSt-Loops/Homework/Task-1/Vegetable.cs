namespace Chef
{
    using Contracts;

    public abstract class Vegetable : IVegetable
    {
        public bool IsRotten { get; set; }
    }
}