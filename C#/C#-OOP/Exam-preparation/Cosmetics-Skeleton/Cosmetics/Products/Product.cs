namespace Cosmetics.Products
{
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public abstract class Product : IProduct
    {
        private const int NameMinLength = 3;
        private const int NameMaxLength = 10;
        private const int BrandMinLength = 2;
        private const int BrandMaxLength = 10;

        private string name;
        private string brand;
        private decimal price;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Brand cannot be null or empty.");

                Validator.CheckIfStringLengthIsValid(value, BrandMaxLength, BrandMinLength, string.Format("Product brand must be between {0} and {1} symbols long!", BrandMinLength, BrandMaxLength));

                this.brand = value;
            }
        }

        public GenderType Gender { get; private set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Name cannot be null or empty.");

                Validator.CheckIfStringLengthIsValid(value, NameMaxLength, NameMinLength, string.Format("Product name must be between {0} and {1} symbols long!", NameMinLength, NameMaxLength));

                this.name = value;
            }
        }

        public virtual decimal Price { get; private set; }

        public virtual string Print()
        {
            var printInfo = new StringBuilder();
            printInfo.AppendLine(string.Format("  * Price: ${0}", this.Price));
            printInfo.Append(string.Format("  * For gender: {0}", this.Gender));

            return printInfo.ToString();
        }
    }
}
