using System;

namespace _2.BankAccountMethods
{
    class Program
    {
        static void Main()
        {
            BankAccount acc = new BankAccount();
            acc.Id = 1;
            acc.Balance = 15;

            Console.WriteLine(acc);
        }
    }
}
