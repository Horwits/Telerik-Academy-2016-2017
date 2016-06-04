namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Validation;

    public class GSM
    {
        private static GSM iPhone4S = new GSM("iPhone 4S", "Apple", 389, "default", new Battery("Apple", BatteryType.LiPo, 200, 8), new Display(3.5, 16000000));

        private string model;
        private string manufacturer;
        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0, null, null, null)
        {
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public string Model
        {
            get { return this.model; }
            private set
            {
                this.model = value;
                MobilePhonePropertiesValidator.ValidateNames(value, "Model value is empty.");
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                this.manufacturer = value;
                MobilePhonePropertiesValidator.ValidateNames(value, "Manufacturer value is empty.");
            }
        }

        public decimal Price { get; set; }

        public string Owner { get; set; }

        public Battery Battery { get; private set; }

        public Display Display { get; private set; }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        public void AddCall(Call newCall)
        {
            MobilePhonePropertiesValidator.ValidateAddCall(newCall, "New call is null.");

            this.callHistory.Add(newCall);
        }

        public void DeleteCall(int callPosition)
        {
            MobilePhonePropertiesValidator.ValidateCallHistory(callPosition, this.callHistory.Count, "Call position is invalid.");

            this.callHistory.RemoveAt(callPosition);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CalculateTotalPriceOfCalls(decimal pricePerMinute)
        {
            MobilePhonePropertiesValidator.ValidateNumbers(pricePerMinute, "Price per minute cannot be negative.");

            var totalPrice = 0m;
            var totalCallsToMinutes = 0m;
            foreach (var calls in this.callHistory)
            {
                totalCallsToMinutes += (decimal)calls.Duration.TotalSeconds;
            }

            int oneHourToMinutes = 60;
            totalCallsToMinutes /= oneHourToMinutes;
            totalPrice = pricePerMinute * totalCallsToMinutes;

            return totalPrice;
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();

            printInfo.AppendFormat("Device name: {0}{1}", this.Model, Environment.NewLine);
            printInfo.AppendFormat("Device manufacturer: {0}{1}", this.Manufacturer, Environment.NewLine);
            printInfo.AppendFormat("Device battery: {0}{1}", this.Battery == null ? "" : this.Battery.ToString(), Environment.NewLine);
            printInfo.AppendFormat("Device display: {0}", this.Display == null ? "" : Environment.NewLine);
            printInfo.AppendFormat("{0}", this.Display == null ? "" : this.Display.ToString());
            return printInfo.ToString();
        }
    }
}
