namespace WarMachines.Machines
{
    using System.Text;

    using WarMachines.Interfaces;

    public class Fighter : Machine, IMachine, IFighter
    {
        private const double InitialHealthPoints = 200D;

        private double healthPoints = InitialHealthPoints;
        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints)
        {
        }

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, attackPoints, defensePoints)
        {
            this.StealthMode = stealthMode;
        }

        public override double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }

            set
            {
                this.healthPoints = value;
            }
        }

        public bool StealthMode
        {
            get
            {
                return this.stealthMode;
            }

            set
            {
                this.stealthMode = value;
            }
        }

        public void ToggleStealthMode()
        {
            if (this.stealthMode)
            {
                this.stealthMode = false;
            }
            else
            {
                this.stealthMode = true;
            }
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();

            printInfo.Append(base.ToString());
            printInfo.Append(string.Format(" *Stealth: {0}", this.StealthMode == true ? "ON" : "OFF"));

            return printInfo.ToString();
        }
    }
}