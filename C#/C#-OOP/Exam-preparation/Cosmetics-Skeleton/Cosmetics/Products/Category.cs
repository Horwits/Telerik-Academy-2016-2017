namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Category : ICategory
    {
        private const int MinLength = 2;
        private const int MaxLength = 15;

        private string name;
        private ICollection<IProduct> products;

        public Category(string name)
        {
            this.Name = name;
            products = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Name cannot be null or empty.");

                Validator.CheckIfStringLengthIsValid(value,
                    MaxLength,
                    MinLength,
                    string.Format("Category name must be between {0} and {1} symbols long!", MinLength, MaxLength));

                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.products.Add(cosmetics);
        }

        public string Print()
        {
            var printInfo = new StringBuilder();

            if (this.products.Count > 0 && this.products.Count != 1)
            {
                printInfo.AppendLine(string.Format("{0} category - {1} products in total", this.Name, this.products.Count));

                AppendProducts(printInfo);

            }
            else if (this.products.Count == 1)
            {
                printInfo.AppendLine(string.Format("{0} category - {1} product in total", this.Name, this.products.Count));

                AppendProducts(printInfo);
            }
            else
            {
                printInfo.AppendFormat("{0} category - {1} products in total", this.Name, this.products.Count);
            }

            return printInfo.ToString();
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            bool isFound = this.products.Remove(cosmetics);
            if (isFound)
            {
                this.products.Remove(cosmetics);
            }
            else
            {
                throw new ArgumentException(string.Format("Product {0} does not exist in category { category name}!", cosmetics.Name, this.GetType().Name));
            }
        }

        private void AppendProducts(StringBuilder printInfo)
        {
            var orderedProducts = this.products
                                            .OrderBy(x => x.Brand)
                                            .ThenByDescending(x => x.Price)
                                            .ToList();

            var counter = 0;
            foreach (var item in orderedProducts)
            {
                if (counter == orderedProducts.Count - 1)
                {
                    printInfo.Append(item.Print());
                }
                else
                {
                    printInfo.AppendLine(item.Print());
                }

                counter++;
            }
        }
    }
}