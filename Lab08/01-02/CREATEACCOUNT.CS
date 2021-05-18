
using System;

class CreateAccount
{
    // Test Harness
    static void Main() 
    {
        BankAccount acc1;
        BankAccount acc2;
        BankAccount acc3;
        BankAccount acc4;
        acc1 = new BankAccount();
        acc2 = new BankAccount(AccountType.Deposit);
        acc3 = new BankAccount(100);
        acc4 = new BankAccount(AccountType.Deposit, 500);

        acc1.Deposit(200);
        acc1.Withdraw(50);
        acc2.Withdraw(20);
        acc2.Deposit(70);
        acc3.Deposit(5);
        acc3.Withdraw(1);
        acc4.Withdraw(10);
        acc4.Withdraw(1);

        Write(acc1);
        Write(acc2);
        Write(acc3);
        Write(acc4);
        Console.Read();
    }
      
    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}",  acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());
        Console.WriteLine("Transactions:");
        foreach (BankTransaction tran in acc.Transactions())
        {
            Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
        }
        Console.WriteLine();
        Console.Read();
    }
}
