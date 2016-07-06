namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using FurnitureManufacturer.Interfaces;

    public class Table : Furniture, IFurniture, ITable
    {
        public Table(string model, string materialType, decimal price, decimal height)
            : base(model, materialType, price, height)
        {
        }

        public Table(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
            : base(model, materialType, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Area
        {
            get
            {
                var area = this.Length * this.Width;
                return area;
            }
        }

        public decimal Length { get; private set; }

        public decimal Width { get; private set; }

        public override string ToString()
        {
            var printInfo = new StringBuilder();

            printInfo.AppendFormat(
                "{0}, Length: {1}, Width: {2}, Area: {3}",
                    base.ToString(),
                    this.Length,
                    this.Width,
                    this.Area);

            return printInfo.ToString();
        }
    }
}