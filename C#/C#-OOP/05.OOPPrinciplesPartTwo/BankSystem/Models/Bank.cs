namespace BankSystem.Models
{
    using System.Collections.Generic;

    using System.Text;

    using BankSystem.Models.Accounts;

    public class Bank
    {
        private ICollection<Account> accounts;

        public Bank()
        {
            this.accounts = new List<Account>();
        }

        private ICollection<Account> Accounts
        {
            get
            {
                return this.accounts;
            }
        }

        public void AddAccount(Account account)
        {
            this.accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            this.accounts.Remove(account);
        }

        public string ListAccounts()
        {
            var printInfo = new StringBuilder();

            foreach (var account in this.Accounts)
            {
                printInfo.AppendLine(account.ToString());
            }

            return printInfo.ToString();
        }
    }
}