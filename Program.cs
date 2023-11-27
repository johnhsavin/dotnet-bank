// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int age = 50;
// age = "fifty";  // can't do this, convert string to integer

string name = "John";
// Console.WriteLine($"your name is {name} and you're {age} years old" ); // special string like template literal

BankAccount newAccount = new BankAccount();    // class + variable name = create new version of bank account

newAccount.Balance = 100.99;

Console.WriteLine($"Your balance is {newAccount.Balance}");