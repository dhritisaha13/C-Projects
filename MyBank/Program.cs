using BankyStuffLibrary;
using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Dhriti", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with Rs {account.Balance}. ");

            account.MakeWithdrawal(1200, DateTime.Now, "Myntra Shopping");
            Console.WriteLine($"Remaining account balance is {account.Balance}");

            account.MakeWithdrawal(500, DateTime.Now, "OnePLus BassBuds");
            Console.WriteLine($"Remaining account balance is {account.Balance}");

            account.MakeDeposit(100, DateTime.Now, "Interest for October");
            Console.WriteLine($"Remaining account balance is {account.Balance}");

            Console.WriteLine(account.GetAccountHistory());

        }
    }
}
