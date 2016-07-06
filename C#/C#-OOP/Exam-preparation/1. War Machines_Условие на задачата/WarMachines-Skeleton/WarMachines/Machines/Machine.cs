namespace WarMachines.Machines
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;

    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        protected IList<string> targets;
        private IPilot pilot;

        public Machine(string name, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.targets = new List<string>();
        }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public virtual double HealthPoints { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.ValidateString(value, "Name");

                this.name = value;
            }
        }

        // TODO: if null value is passed -> throw propper exception 
        public IPilot Pilot { get; set; }

        public IList<string> Targets
        {
            get
            {
                return new List<string>(this.targets);
            }
        }

        public void Attack(string target)
        {
            // TODO: Implement
            this.targets.Add(target);
        }

        public override string ToString()
        {
            var printInfo = new StringBuilder();

            printInfo.AppendLine(string.Format("- {0}", this.Name));
            printInfo.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            printInfo.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            printInfo.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            printInfo.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));
            printInfo.AppendLine(string.Format(" *Targets: {0}", this.Targets.Count == 0 ? "None" : string.Join(", ", this.Targets)));

            return printInfo.ToString();
        }
    }
}
