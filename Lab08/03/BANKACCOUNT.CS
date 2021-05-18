using System;
using System.IO;
using System.Collections;

sealed class BankAccount: IDisposable
{
	private long accNo;
    private decimal accBal;
    private AccountType accType;
	private Queue tranQueue = new Queue();
    private static long nextNumber = 123;
    bool disposed = false;

    public void Dispose()
    {
        if (disposed = true)
        {
            Console.WriteLine("The variable is set to true.");
        }
        else
        {
            StreamWriter newopen = File.AppendText("Transactions.Dat");
            newopen.WriteLine("Account number is {0}", accNo);
            newopen.WriteLine("Account balance is {0}", accBal);
            newopen.WriteLine("Account type is {0}", accType);
            newopen.WriteLine("Transactions:");
            foreach (BankTransaction tran in tranQueue)
            {
                newopen.WriteLine("Date/Time:{0}\tAmount:{1}", tran.When(), tran.Amount());
            }
            newopen.Close();
            disposed = true;
            GC.SuppressFinalize(this);
        }
    }

	// Constructors
    public BankAccount()
    {
        accNo = NextNumber();
        accType = AccountType.Checking;
	    accBal = 0;
    }

    public BankAccount(AccountType aType)
	{
		accNo = NextNumber();
		accType = aType;
		accBal = 0;
	}

	public BankAccount(decimal aBal)
	{
		accNo = NextNumber();
		accType = AccountType.Checking;
		accBal = aBal;
	}

	public BankAccount(AccountType aType, decimal aBal)
	{
		accNo = NextNumber();
		accType = aType;
		accBal = aBal;
	}

    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds) {
            accBal -= amount;
			BankTransaction tran = new BankTransaction(-amount);
			tranQueue.Enqueue(tran);
        }
        return sufficientFunds;
    }
    
    public decimal Deposit(decimal amount)
    {
        accBal += amount;
		BankTransaction tran = new BankTransaction(amount);
		tranQueue.Enqueue(tran);
        return accBal;
    }

	public Queue Transactions()
	{
		return tranQueue;
	}
    
    public long Number()
    {
        return accNo;
    }
    
    public decimal Balance()
    {
        return accBal;
    }
    
    public string Type()
    {
        return accType.ToString();
    }

    private static long NextNumber()
    {
        return nextNumber++;
    }
    ~BankAccount()
    {
        Dispose();
    }
}
