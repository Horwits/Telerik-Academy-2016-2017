namespace WarMachines.Machines
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines = new List<IMachine>();

        public Pilot(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.ValidateString(value, "Name");
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            this.machines.Add(machine);
        }

        public string Report()
        {
            // TODO: The machines should be ordered by health points then by name. If the pilot has no machines added, print “no machines”. If the pilot has 1 machine, print “1 machine” and list it.
            //(pilot name) – (number of machines/”no”) (“machine”/”machines”)
            var printInfo = new StringBuilder();

            if (this.machines.Count == 0)
            {
                printInfo.Append(string.Format("{0} – {1}", this.Name, "no machines"));
            }
            else if (true)
            {
                printInfo.AppendLine(
               string.Format("{0} – {1}", this.Name, this.machines.Count == 1 ?
                                                                        "1 machine" :
                                                                        this.machines.Count.ToString() +
                                                                        " machines"));
            }


            printInfo.Append(
                string.Format(
                    "{0}",
                    string.Join("\n\r", this.machines.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name).ToList())));

            return printInfo.ToString();
        }



    }
}