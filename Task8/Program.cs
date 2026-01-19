public class Program
{
    public static int GetFinalBalance(int initialBalance, int[] transactions)
    {
        int balance = initialBalance;

        foreach (int transaction in transactions)
        {
            if (transaction >= 0)
            {
                balance += transaction;// Deposit
            }
            else
            {
                if (balance + transaction >= 0) // Withdraw only if enough balance
                {
                    balance += transaction;
                }
            }
        }

        return balance;
    }

    public static void Main()
    {
        int initialBalance = 1000;
        int[] transactions = { 200, -300, -500, 400, -900 };

        int finalBalance = GetFinalBalance(initialBalance, transactions);
        Console.WriteLine(finalBalance);
    }
}
