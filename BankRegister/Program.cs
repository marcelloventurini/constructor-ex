using BankRegister;

Account account;

Console.Write("Informe o número da conta: ");
string accountNumber = Console.ReadLine();

Console.Write("Informe o títular da conta: ");
string accountHolder = Console.ReadLine();

Console.Write("Gostaria de realizar um depósito inicial? (s/n): ");
char answer = char.Parse(Console.ReadLine());
if (answer == 's')
{
    Console.Write("Informe o valor do depósito inicial: ");
    double initialDeposit = double.Parse(Console.ReadLine());

    account = new Account(accountNumber, accountHolder, initialDeposit);
}
else
{
    account = new Account(accountNumber, accountHolder);
}

Console.WriteLine(account);

Console.Write("Informe um valor para depósito: ");
double deposit = double.Parse(Console.ReadLine());
account.Deposit(deposit);

Console.WriteLine("Dados atualizados:");
Console.WriteLine(account);

Console.Write("Informe um valor para saque: ");
double withdraw = double.Parse(Console.ReadLine());
account.Withdraw(withdraw);

Console.WriteLine("Dados atualizados:");
Console.WriteLine(account);
