namespace FurnitureManufacturer.Models
{
    using System.Text;

    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IFurniture, IChair, IConvertibleChair
    {
        private readonly decimal heightValue;

        private bool isConverted = false;

        public ConvertibleChair(string model, string materialType, decimal price, decimal height)
            : base(model, materialType, price, height)
        {
        }

        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
            this.heightValue = height;
        }

        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }
        }

        public void Convert()
        {
            if (this.isConverted)
            {
                this.Height = this.heightValue;
                this.isConverted = false;
            }
            else
            {
                this.Height = 0.10M;
                this.isConverted = true;
            }
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();

            printInfo.AppendFormat("{0}, State: {1}", base.ToString(), this.IsConverted ? "Converted" : "Normal");

            return printInfo.ToString();
        }
    }
}