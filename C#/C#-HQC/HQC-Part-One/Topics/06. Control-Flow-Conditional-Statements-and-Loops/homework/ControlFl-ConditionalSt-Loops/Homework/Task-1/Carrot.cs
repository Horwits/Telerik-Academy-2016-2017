namespace Chef
{
    using Contracts;

    public class Carrot : Vegetable, IVegetable, IPeelable
    {
        public bool HasBeenPeeled { get; set; }
    }
}