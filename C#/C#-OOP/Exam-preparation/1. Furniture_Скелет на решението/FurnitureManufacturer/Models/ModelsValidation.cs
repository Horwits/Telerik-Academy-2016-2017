namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class ModelsValidation
    {
        ////validation for both

        public static void ValidateString(string value, string name)
        {
            if (value == null)
            {
                throw new ArgumentNullException(name + " cannot be null.");
            }
        }

        //// validate company
        public static void ValidateCompanyName(string value)
        {
            if (value.Length < 5)
            {
                throw new ArgumentOutOfRangeException("Company name cannot be less than five symbols.");
            }

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Company name cannot be null or empty.");
            }
        }

        public static void ValidateCompanyRegistrationNumber(string value)
        {
            if (value.Length != 10)
            {
                throw new ArgumentOutOfRangeException("Registration number must be exactly 10 symbols.");
            }

            var areThereOtherSymbolsThanDigitInValue = value.All(s => s >= '0' && s <= '9');
            if (!areThereOtherSymbolsThanDigitInValue)
            {
                throw new FormatException("Registration number must contain only digits.");
            }
        }

        //// validate furniture
        public static void ValidateFurnitureModel(string value)
        {
            if (value.Length < 3)
            {
                throw new ArgumentOutOfRangeException("Furniture model cannot be less than three symbols.");
            }

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Furniture model cannot be null or empty.");
            }
        }

        public static void ValidateFurniturePrice(decimal value)
        {
            if (value <= 0M)
            {
                throw new ArgumentOutOfRangeException("Furniture price cannot be less than or equal to zero.");
            }
        }

        public static void ValidateFurnitureHeight(decimal value)
        {
            if (value <= 0M)
            {
                throw new ArgumentOutOfRangeException("Furniture height cannot be less than or equal to zero.");
            }
        }
    }
}