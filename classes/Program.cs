using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Test", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} as the initial balance.");
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Gift");
            Console.WriteLine(account.Balance);

            // try
            // {
            //     BankAccount newAccount = new BankAccount("Guy", -1000);
            // }
            // catch (ArgumentOutOfRangeException e)
            // {
            //     Console.WriteLine("Exception caught creating account with negative balance");
            //     Console.WriteLine(e.ToString());
            // }

            // try
            // {
            //     account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            // }
            // catch(InvalidOperationException e)
            // {
            //     Console.WriteLine("Exception caught trying to overdraw");
            //     Console.WriteLine(e.ToString());
            // }

            Console.WriteLine(account.GetAccountHistory());

        }
    }
}
