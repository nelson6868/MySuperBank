using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Nelson", 1000);
            Console.Title = "ATM Console App";
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
        }
    }
}