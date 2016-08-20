namespace InversionOfControlExample
{
    using System;
    using System.Collections.Generic;

    public interface ICustomerRepositiory
    {
        void Add(ICustomer customer);

        IEnumerable<ICustomer> GetAll();
    }
}