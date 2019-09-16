using System;
using System.Collections.Generic;

namespace classes
{
  public class BankAccount
  {
    public BankAccount(string name, decimal initialBalance)
    {
      this.Owner = name;
      // this.Balance = initialBalance;
      MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
      this.Number = accountNumberSeed.ToString();
      accountNumberSeed++;
    }

    private static int accountNumberSeed = 1234567890;
    private List<Transaction> allTransactions = new List<Transaction>();
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance 
    {
      get 
      {
        decimal balance = 0;
        foreach(Transaction item in allTransactions)
        {
          balance += item.Amount;
        }

        return balance;
      }
    }
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
      if(amount <= 0)
      {
        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
      }
      Transaction deposit = new Transaction(amount, date, note);
      allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
      if(amount <= 0)
      {
        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
      }
      if(Balance - amount < 0)
      {
        throw new InvalidOperationException("Not sufficient funds for this withdrawal");
      }
      Transaction withdrawal = new Transaction(-amount, date, note);
      allTransactions.Add(withdrawal);
    }

    public string GetAccountHistory()
    {
      var report = new System.Text.StringBuilder();

      report.AppendLine("Date\tAmount\tNote");
      foreach (Transaction item in allTransactions)
      {
        report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
      }

      return report.ToString();
    }
  }
}