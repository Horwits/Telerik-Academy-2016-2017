namespace MobilePhoneDevice
{
    using System;
    using System.Text;

    using MobilePhoneDevice.Validation;

    public class Display
    {
        private double size;
        private int numberOfColors;

        public Display(double size, int numberOfColors)
        {
            this.Size = size;

            this.NumberOfColors = numberOfColors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }

            private set
            {
                this.size = value;
                MobilePhonePropertiesValidator.ValidateNumbers(value, "Size is invalid.");
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            private set
            {
                this.numberOfColors = value;
                MobilePhonePropertiesValidator.ValidateNumbers(value, "Number of colors value is invalid.");
            }
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();
            printInfo.AppendFormat("Size {0}{1}", this.Size, Environment.NewLine);
            printInfo.AppendFormat("Number Of colors {0}", this.NumberOfColors);

            return printInfo.ToString();
        }
    }
}
