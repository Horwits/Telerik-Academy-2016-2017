namespace BankSystem.Models.Accounts
{
    using BankSystem.Models.Accounts.Interfaces;

    using BankSystem.Models.Customers;

    using Validation;

    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, uint interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public void Deposite(decimal ammount)
        {
            this.Balance += ammount;
        }

        public override decimal CalculateInterestAmmount(uint numberOfMonths)
        {
            Validation.ValidateMonth(numberOfMonths);

            if (this.Customer == Customer.Individual)
            {
                if (numberOfMonths <= 3)
                {
                    return 0.0M;
                }
            }
            else if (this.Customer == Customer.Company)
            {
                if (numberOfMonths <= 2)
                {
                    return 0.0M;
                }
            }

            return base.CalculateInterestAmmount(numberOfMonths);
        }
    }
}