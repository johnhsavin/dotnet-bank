using System.Security.Cryptography.X509Certificates;

public class BankAccount
{
  // public or private is similar to export in JS. Variable must be defined when added.
  private double Balance = 0;
  public string OwnersName = "";

  // constructor
  public BankAccount(string NewOwnersName, double initialBalance)
  {
    this.OwnersName = NewOwnersName;
    this.Deposit(initialBalance);
    this.Deposit(100); // for new account
  }

  public double Deposit(double amount)
  {
    if (amount < 0.00)
    {
      throw new Exception("Nope"); // way to respond back to user
    }
    this.Balance += amount;
    return this.Balance;
  }

  public double Withdraw(double amount)
  {

    if (amount < 0)
    {
      throw new Exception("No negative number");
    }

    if (amount > this.Balance)
    {
      throw new Exception("Insufficient funds");
    }

    this.Balance -= amount;
    return this.Balance;

  }
  public double getBalance()
  {
    return this.Balance;
  }

}