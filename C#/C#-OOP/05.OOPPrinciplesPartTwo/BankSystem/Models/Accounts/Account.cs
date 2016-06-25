namespace BankSystem.Models.Accounts
{
    using BankSystem.Models.Customers;

    public abstract class Account
    {
        public Account(Customer customer, decimal balance, uint interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }

        public decimal Balance { get; set; }

        public uint InterestRate { get; set; }

        public virtual decimal CalculateInterestAmmount(uint numberOfMonths)
        {
            var interestAmmount = this.InterestRate * numberOfMonths;
            return interestAmmount;
        }

        public override string ToString()
        {
            return "Customer type: " + this.Customer + "\n\r" + "Balance: " + this.Balance + "\n\r" + "Interest rate: " + this.InterestRate;
        }
    }
}