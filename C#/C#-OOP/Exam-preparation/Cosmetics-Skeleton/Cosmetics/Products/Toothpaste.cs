namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Toothpaste : Product, IProduct, IToothpaste
    {
        private List<string> ingredients = new List<string>();

        public Toothpaste(string name, string brand, decimal price, GenderType gender)
            : base(name, brand, price, gender)
        {
        }

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.Ingredients = ingredients;
        }

        public IList<string> Ingredients
        {
            get
            {
                return this.ingredients;
            }

            private set
            {
                this.ingredients.AddRange(value);

                foreach (var item in this.ingredients)
                {
                    Validator.CheckIfStringLengthIsValid(item, 12, 4, string.Format("Each ingredient must be between {0} and {1} symbols long!", 4, 12));
                }
            }
        }

        public override string Print()
        {
            var printInfo = new StringBuilder();
            printInfo.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            printInfo.AppendLine(base.Print());
            printInfo.Append(string.Format("  * Ingredients: {0}", string.Join(", ", this.Ingredients)));
            return printInfo.ToString();
        }
    }
}