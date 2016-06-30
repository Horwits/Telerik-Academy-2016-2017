namespace Cosmetics.Products
{
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Shampoo : Product, IProduct, IShampoo
    {
        public Shampoo(string name, string brand, decimal price, GenderType gender)
            : base(name, brand, price, gender)
        {

        }

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public override decimal Price
        {
            get
            {
                return base.Price * this.Milliliters;
            }
        }

        public uint Milliliters { get; private set; }

        public UsageType Usage { get; private set; }

        public override string Print()
        {
            var printInfo = new StringBuilder();
            printInfo.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            printInfo.AppendLine(base.Print());
            printInfo.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            printInfo.AppendFormat("  * Usage: {0}", this.Usage);

            return printInfo.ToString();
        }
    }
}