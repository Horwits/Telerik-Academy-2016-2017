namespace InversionOfControlExample
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class CustomerService
    {
        private readonly ICustomerRepositiory repositiory;

        public CustomerService(ICustomerRepositiory repositiory)
        {
            this.repositiory = repositiory;
        }

        public void CreateCustomer(string name, int id)
        {
            var customer = new Customer(name, id);

            if (this.repositiory == null)
            {
                throw new ArgumentNullException();
            }

            try
            {
                this.repositiory.Add(customer);
            }
            catch (AddCustomerException exc)
            {
                throw new CreateCustomerException("", exc);
                throw;
            }
        }

        public IEnumerable<ICustomer> GetAllCustomersWhere(Func<ICustomer, bool> predicate)
        {
            return this.repositiory.GetAll().Where(predicate);
        }
    }
}