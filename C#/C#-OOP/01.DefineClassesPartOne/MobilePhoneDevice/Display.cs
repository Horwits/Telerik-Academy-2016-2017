namespace MobilePhoneDevice
{
    using System;
    using System.Text;

    using MobilePhoneDevice.Validation;
    public class Display
    {
        //TODO: add the validation to the propeties
        public Display(double size, int numberOfColors)
        {
            MobilePhonePropertiesValidator.ValidateNumbers(size, "Size is invalid.");
            this.Size = size;

            MobilePhonePropertiesValidator.ValidateNumbers(numberOfColors, "Number of colors value is invalid.");
            this.NumberOfColors = numberOfColors;
        }

        public double Size { get; private set; }

        public int NumberOfColors { get; private set; }

        public override string ToString()
        {
            var printInfo = new StringBuilder();
            printInfo.AppendFormat("Size {0}{1}", this.Size , Environment.NewLine);
            printInfo.AppendFormat("Number Of colors {0}", this.NumberOfColors);

            return printInfo.ToString();
        }
    }
}
