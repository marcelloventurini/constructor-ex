namespace BankRegister
{
    internal class Account
    {
        public string AccountNumber { get; private set; }
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }

        public Account(string accountNumber, string accountHolder)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
        }

        public Account(string accountNumber, string accountHolder, double initialDeposit) : this(accountNumber, accountHolder)
        {
            Deposit(initialDeposit);
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public void Withdraw(double value)
        {
            Balance = (Balance - value) - 5.00;
        }

        public override string ToString()
        {
            return "Dados da conta: "
                + "Nro.: "
                + AccountNumber
                + "; Titular: "
                + AccountHolder
                + "; Saldo: R$"
                + Balance.ToString("F2");
        }
    }
}
