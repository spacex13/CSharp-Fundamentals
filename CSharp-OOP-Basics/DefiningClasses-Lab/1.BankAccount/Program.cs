﻿using System;

public class Program
{
    public static void Main()
    {
        BankAccount acc = new BankAccount();
        acc.Id = 1;
        acc.Balance = 15;

        Console.WriteLine($"Account ID{acc.Id}, balance {acc.Balance}");
    }
}

