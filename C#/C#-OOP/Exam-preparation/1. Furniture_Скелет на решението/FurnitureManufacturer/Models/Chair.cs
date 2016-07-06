namespace FurnitureManufacturer.Models
{
    using System.Text;

    using FurnitureManufacturer.Interfaces;

    public class Chair : Furniture, IFurniture, IChair
    {
        private int numberOfLegs;

        public Chair(string model, string materialType, decimal price, decimal height)
            : base(model, materialType, price, height)
        {
        }

        public Chair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }

            protected set
            {
                this.numberOfLegs = value;
            }
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();

            printInfo.AppendFormat(
                                    "{0}, Legs: {1}", 
                                    base.ToString(),
                                    this.NumberOfLegs);

            return printInfo.ToString();
        }
    }
}