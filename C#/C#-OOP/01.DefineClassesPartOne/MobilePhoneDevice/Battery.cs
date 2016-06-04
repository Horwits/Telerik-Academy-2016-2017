namespace MobilePhoneDevice
{
    using System;
    using System.Text;

    using MobilePhoneDevice.Validation;

    public class Battery
    {
        private string model;
        private decimal hoursIdle;

        public Battery(string model, BatteryType type, decimal hoursIdle, decimal hoursTalk)
        {
            this.Model = model;
            this.Type = type;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                this.model = value;

                MobilePhonePropertiesValidator.ValidateNames(value, "Model value is empty.");
            }
        }

        public BatteryType Type { get; private set; }

        public decimal HoursIdle
        {
            get { return this.hoursIdle; }
            private set
            {
                this.hoursIdle = value;

                MobilePhonePropertiesValidator.ValidateNumbers(value, "Idle value is invalid.");
            }
        }

        public decimal HoursTalk { get; private set; }

        public override string ToString()
        {
            var printInfo = new StringBuilder();
            printInfo.Append(Environment.NewLine);
            printInfo.AppendFormat("Model {0}{1}", this.Model, Environment.NewLine);
            printInfo.AppendFormat("Type {0}{1}", this.Type, Environment.NewLine);
            printInfo.AppendFormat("Hours Idle {0}{1}", this.HoursIdle, Environment.NewLine);
            printInfo.AppendFormat("Hours talk {0}", this.HoursTalk);

            return printInfo.ToString();
        }
    }
}
