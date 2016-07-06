namespace FurnitureManufacturer.Models
{
    using System.Text;

    using FurnitureManufacturer.Interfaces;

    public abstract class Furniture : IFurniture
    {
        private string model;
        private decimal price;
        private string material;
        private decimal height;

        public Furniture(string model, string materialType, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = materialType;
            this.Price = price;
            this.Height = height;
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }

            protected set
            {
                ModelsValidation.ValidateFurnitureHeight(value);
                this.height = value;
            }
        }

        public string Material
        {
            get
            {
                return this.material;
            }

            protected set
            {
                ModelsValidation.ValidateString(value, "Furniture material");
                this.material = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            protected set
            {
                ModelsValidation.ValidateFurnitureModel(value);
                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                ModelsValidation.ValidateFurniturePrice(value);
                this.price = value;
            }
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();

            printInfo.AppendFormat(
                "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}",
                    this.GetType().Name,
                    this.Model,
                    this.Material = this.Material[0].ToString().ToUpper() + this.Material.Substring(1),
                    this.Price,
                    this.Height);

            return printInfo.ToString();
        }
    }
}