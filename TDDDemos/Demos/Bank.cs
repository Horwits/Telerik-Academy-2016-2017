namespace Demos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Bank
    {
        private decimal amount;

        public decimal Amount
        {
            get
            {
                return this.amount;
            }

            set
            {

                // TODO Validation 
                this.amount = value;
            }
        }
    }
}