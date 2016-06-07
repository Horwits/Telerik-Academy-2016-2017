namespace MobilePhoneDevice
{
    using System;
    using System.Text;

    using MobilePhoneDevice.Validation;

    public class Call
    {
        private string time;
        private string phoneNumber;

        public Call(DateTime date, TimeSpan duration, string phoneNumber)
        {
            this.Date = date;
            this.time = string.Format("{0}:{1}", this.Date.Hour, this.Date.Minute);
            this.Duration = duration;
            this.PhoneNumber = phoneNumber;
        }

        public DateTime Date { get; set; }

        public string Time
        {
            get
            {
                return this.time;
            }
        }

        public TimeSpan Duration
        {
            get;
            set;
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            set
            {
                this.phoneNumber = value;

                MobilePhonePropertiesValidator.ValidatePhoneNumber(value, "Phone number is invalid.");
            }
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();
            printInfo.AppendFormat("Date: {0:dd.MM.yyyy}{1}", this.Date.Date, Environment.NewLine);
            printInfo.AppendFormat("Time: {0}{1}", this.Time, Environment.NewLine);
            printInfo.AppendFormat("Duration: {0}{1}", this.Duration.TotalSeconds.ToString(), Environment.NewLine);
            printInfo.AppendFormat("Phone Number: {0}", this.PhoneNumber);

            return printInfo.ToString();
        }
    }
}
