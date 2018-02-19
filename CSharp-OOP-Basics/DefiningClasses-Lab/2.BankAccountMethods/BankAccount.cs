using System;
using System.Collections.Generic;
using System.Text;

public class BankAccount
{
    int id;
    decimal balance;

    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public decimal Balance
    {
        get { return this.balance; }
        set { this.balance = value; }
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        Balance -= amount;
    }

    public override string ToString()
    {
        return $"Account ID{this.id}, balance {this.balance:F2}";
    }
}