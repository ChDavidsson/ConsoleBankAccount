namespace ConsoleBankAccount;

public class BankAccount
{
    private decimal balance;
    public decimal Balance
    {
        get
        {
            return balance;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Balance cannot be negative.");
            }
            else
            {
                balance = value;
            }
        }
    }
    
}
