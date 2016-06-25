namespace BankSystem.Models.Accounts
{
    using System;

    using BankSystem.Models.Accounts.Interfaces;
    using Customers;
    using Validation;

    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, uint interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestAmmount(uint numberOfMonths)
        {
            Validation.ValidateMonth(numberOfMonths);

            if (this.Customer == Customers.Customer.Individual)
            {
                if (numberOfMonths <= 12)
                {
                    return numberOfMonths * (this.Balance * 0.5m);
                }
                else
                {
                    return (12 * (this.Balance * 0.5m)) + ((numberOfMonths - 12) * ((this.InterestRate / 100) * this.Balance));
                }
            }
            else
            {
                if (numberOfMonths <= 6)
                {
                    return 0.0M;
                }
                else
                {
                    return (numberOfMonths - 6) * ((this.InterestRate / 100.0m) * this.Balance);
                }
            }
        }

        public void Deposite(decimal ammount)
        {
            this.Balance += ammount;
        }
    }
}