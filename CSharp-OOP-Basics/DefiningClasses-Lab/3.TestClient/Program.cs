using System;
using System.Collections.Generic;

namespace _3.TestClient
{
    class Program
    {
        static void Main()
        {
            string commandInfo;
            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

            while ((commandInfo = Console.ReadLine()) != "End")
            {
                var command = commandInfo.Split();
                int id = int.Parse(command[1]);

                switch (command[0])
                {
                    case "Create":
                        if (accounts.ContainsKey(id))
                        {
                            Console.WriteLine("Account already exists");
                        }
                        else
                        {
                            accounts.Add(id, new BankAccount() {ID = id});
                        }
                        break;
                    case "Deposit":
                        if (AccountExists(accounts, id))
                        {
                            decimal amount = decimal.Parse(command[2]);
                            accounts[id].Deposit(amount);
                        }
                        break;
                    case "Withdraw":
                        if (AccountExists(accounts, id))
                        {
                            decimal amount = decimal.Parse(command[2]);
                            accounts[id].Withdraw(amount);
                        }
                        break;
                    case "Print":
                        if (AccountExists(accounts, id))
                        {
                            Console.WriteLine(accounts[id]);
                        }
                        break;
                }
            }
        }

        static bool AccountExists(Dictionary<int, BankAccount> accounts, int id)
        {
            if (accounts.ContainsKey(id))
            {
                return true;
            }

            Console.WriteLine("Account does not exist");
            return false;
        }
    }
}
