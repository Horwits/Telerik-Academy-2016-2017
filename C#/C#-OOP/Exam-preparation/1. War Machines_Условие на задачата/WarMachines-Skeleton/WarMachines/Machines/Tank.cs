namespace WarMachines.Machines
{
    using System.Text;

    using WarMachines.Interfaces;

    public class Tank : Machine, IMachine, ITank
    {
        private const double InitialHealthPoints = 100D;

        private bool defenseMode;
        private double healthPoints = InitialHealthPoints;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints)
        {
            this.DefenseMode = true;
        }

        // TODO: Implement
        public override double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }

            set
            {
                this.healthPoints += value;
            }
        }

        public bool DefenseMode
        {
            get
            {
                return this.defenseMode;
            }

            private set
            {
                if (value)
                {
                    this.DefensePoints += 30;
                    this.AttackPoints -= 40;
                }

                this.defenseMode = value;
            }
        }

        public void ToggleDefenseMode()
        {
            if (this.defenseMode == true)
            {
                this.defenseMode = false;
            }
            else
            {
                this.defenseMode = true;
            }
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();

            printInfo.Append(base.ToString());
            printInfo.Append(string.Format(" *Defense: {0}", this.DefenseMode == true ? "ON" : "OFF"));

            return printInfo.ToString();
        }
    }
}