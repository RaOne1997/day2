class Saving : Account, bankoperation
{

  protected  static double mainbalance = 0d;
    protected static string DepositAmount = "0";
    double rateOfInterest = 4.5;
    public void MoneyDeposit()
    {
        Console.WriteLine("Enter how much amout you wan to Deposit");
        DepositAmount = Console.ReadLine();
        mainbalance += int.Parse(DepositAmount);
    }

    public void Moneywithdraw()
    {
        Console.WriteLine("Enter how much amout you wan to W");
        DepositAmount = Console.ReadLine();
        mainbalance -= int.Parse(DepositAmount);
        Console.WriteLine("Saving Moneywithdraw ");
    }

    public void updateBalance()
    {
        Console.WriteLine("Balance : - " + mainbalance);
    }
    public  void CalculateInterest()
    {
        var interest = mainbalance * 3 * rateOfInterest / 100;
        mainbalance += interest;

    }
}
