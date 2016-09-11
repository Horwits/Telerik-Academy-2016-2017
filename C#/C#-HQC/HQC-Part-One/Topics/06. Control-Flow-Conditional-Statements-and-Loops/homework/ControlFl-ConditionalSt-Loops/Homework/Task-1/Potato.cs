namespace Chef
{
    using Contracts;

    public class Potato : Vegetable, IVegetable, IPeelable
    {
        public bool HasBeenPeeled { get; set; }
    }
}