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
        if (mainbalance == 0)
        {
            Console.WriteLine("Negative Balance is  not allow");

        }
        else
        {
            Console.WriteLine("Enter how much amout you wan to W");
            DepositAmount = Console.ReadLine();
            mainbalance -= int.Parse(DepositAmount);
            Console.WriteLine("Saving Moneywithdraw ");
        }
    }

    public void updateBalance( string Name)
    {
        Console.WriteLine($"Balance of {Name} is {mainbalance}");
    }
    public  void CalculateInterest()
    {
        var interest = mainbalance * 3 * rateOfInterest / 100;
        mainbalance += interest;

    }
}
