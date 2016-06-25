namespace BankSystem
{
    using System;
    using System.Collections.Generic;

    using BankSystem.Models;
    using BankSystem.Models.Accounts;
    using BankSystem.Models.Customers;

    internal class BankSystemTest
    {
        internal static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Calculate interest test: ");

            var depA = new DepositAccount(Customer.Company, 80000M, 45);
            var loA = new LoanAccount(Customer.Individual, 7500M, 22);
            var morA = new MortgageAccount(Customer.Individual, 30500M, 50);

            var accounts = new List<Account>();
            accounts.Add(depA);
            accounts.Add(loA);
            accounts.Add(morA);

            Console.ForegroundColor = ConsoleColor.White;
            foreach (var acc in accounts)
            {
                var months = RandomMonths();
                Console.WriteLine(acc.CalculateInterestAmmount((uint)months));
            }

            Console.Write(Environment.NewLine);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bank test: ");

            var bank = new Bank();

            bank.AddAccount(depA);
            bank.AddAccount(loA);
            bank.AddAccount(morA);
            bank.AddAccount(new DepositAccount(Customer.Company, 175000M, 12));
            bank.AddAccount(new DepositAccount(Customer.Individual, 12450M, 13));
            bank.AddAccount(new LoanAccount(Customer.Individual, 129M, 2));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(bank.ListAccounts());
        }

        internal static int RandomMonths()
        {
            var random = new Random();
            var res = 0;
            for (int i = 0; i < 13; i++)
            {
                res = random.Next(1, 13);
            }

            res = random.Next(1, 13);

            return res;
        }
    }
}
