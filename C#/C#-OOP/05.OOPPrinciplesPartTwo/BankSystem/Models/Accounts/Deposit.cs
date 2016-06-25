namespace BankSystem.Models.Accounts
{
    using System;

    using BankSystem.Models.Accounts.Interfaces;
    using Customers;
    using Validation;

    public class DepositAccount : Account, IDepositable, IWithDrawable
    {
        public DepositAccount(Customer customer, decimal balance, uint interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public void Deposite(decimal ammount)
        {
            this.Balance += ammount;
        }

        public void WithDraw(decimal ammount)
        {
            this.Balance -= ammount;
        }

        public override decimal CalculateInterestAmmount(uint numberOfMonths)
        {
            Validation.ValidateMonth(numberOfMonths);

            if (this.Balance > 0M && this.Balance < 1000M)
            {
                return base.CalculateInterestAmmount(numberOfMonths);
            }

            return 0.0M;
        }
    }
}