namespace ConsoleBankAccount;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        Console.WriteLine("Enter amount you want to deposit:");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());
        account.Balance = deposit;
        Console.WriteLine($"Deposit successful. Current balance: {account.Balance}");
    }
}
