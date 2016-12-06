namespace StudentsAndWorkers
{
    using Validation;

    public class Worker : Human
    {
        private decimal weekSalary;
        private uint workHoursPerDay;

        public Worker(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public Worker(string firstName, string lastName, decimal weekSalary, uint workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                ValidationUtils.ValidateDecimal(value);
                this.weekSalary = value;
            }
        }

        public uint WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                ValidationUtils.ValidateUInt(value);
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            var dailySalary = this.WeekSalary / 7;
            var moneyPerHour = dailySalary / this.WorkHoursPerDay;

            return moneyPerHour;
        }

        public override string ToString()
        {
            return base.ToString() +
                        "\n\r" + "Week salary: " + this.WeekSalary +
                        "\n\r" + "Work hours per day: " + this.WorkHoursPerDay;
        }
    }
}
