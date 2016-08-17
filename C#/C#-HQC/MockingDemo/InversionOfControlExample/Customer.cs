namespace InversionOfControlExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Customer : ICustomer
    {
        private string name;
        private int id;

        public Customer(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }
    }
}