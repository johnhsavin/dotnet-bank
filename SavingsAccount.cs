public class SavingsAccount : BankAccount {

  // constructor
  public SavingsAccount(string NewOwnersName, double initialBalance)
  : base(NewOwnersName, initialBalance)
  {
this.Deposit(100); // give extra 100 because it's a savings acct
  }
}


public class CheckingAccount : BankAccount {

  // constructor
  public CheckingAccount(string NewOwnersName, double initialBalance)
  : base(NewOwnersName, initialBalance)
  {

  }
}