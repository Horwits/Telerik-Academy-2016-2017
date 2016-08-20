namespace InversionOfControlExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CustomerRepositiory : ICustomerRepositiory
    {
        private ICollection<ICustomer> customers;

        public CustomerRepositiory()
        {
            this.customers = new List<ICustomer>();
        }

        public void Add(ICustomer customer)
        {
            this.customers.Add(customer);
        }

        public IEnumerable<ICustomer> GetAll()
        {
            return this.customers;
        }
    }
}