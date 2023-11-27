// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int age = 50;
// age = "fifty";  // can't do this, convert string to integer

string name = "John";
// Console.WriteLine($"your name is {name} and you're {age} years old" ); // special string like template literal

try {

SavingsAccount newAccount = new SavingsAccount("Bobby", 100.99);    // class + variable name = create new version of bank account

// newAccount.Balance = 100.99;
// newAccount.Balance =newAccount.Balance + 100;

newAccount.Deposit(50.00);

newAccount.Withdraw(40.00);

Console.WriteLine($"Your balance is {newAccount.getBalance()}");
} catch (Exception err) {
  Console.WriteLine($" you got an error {err.Message}");
}
