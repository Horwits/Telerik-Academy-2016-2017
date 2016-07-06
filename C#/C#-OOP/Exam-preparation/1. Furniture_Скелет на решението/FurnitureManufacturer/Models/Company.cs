namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;

    using FurnitureManufacturer.Interfaces;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private IList<IFurniture> innerFurnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            innerFurnitures = new List<IFurniture>();
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return new ReadOnlyCollection<IFurniture>(this.innerFurnitures);
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                ModelsValidation.ValidateCompanyName(value);
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }

            private set
            {
                ModelsValidation.ValidateCompanyRegistrationNumber(value);
                this.registrationNumber = value;
            }
        }

        public void Add(IFurniture furniture)
        {
            this.innerFurnitures.Add(furniture);
        }

        public string Catalog()
        {
            var printInfo = new StringBuilder();

            printInfo.AppendFormat(
                                    "{0} - {1} - {2} {3}",
                                    this.Name,
                                    this.RegistrationNumber,
                                    this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                                    this.Furnitures.Count != 1 ? "furnitures" : "furniture");

            if (this.Furnitures.Count >= 1)
            {
                var ordered = this.Furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model).ToList();
                printInfo.AppendFormat("{0}{1}", Environment.NewLine, string.Join(Environment.NewLine, ordered));
            }

            return printInfo.ToString();
        }

        public IFurniture Find(string model)
        {
            return this.innerFurnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());
        }

        public void Remove(IFurniture furniture)
        {
            foreach (var furn in this.innerFurnitures)
            {
                if (ReferenceEquals(furn, furniture))
                {
                    this.innerFurnitures.Remove(furn);
                    break;
                }
            }
        }
    }
}
