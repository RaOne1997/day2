class Current : Account, bankoperation
{
    protected static double mainbalance = 0d;
    protected static string DepositAmount = "0";
    protected static string WithdrawAmount = "0";
    protected string Cheque_number;
    public void MoneyDeposit()
    {
        Console.WriteLine(" Current MoneyDeposit ");
    }

    public void Moneywithdraw()
    {
        var s = new string('*', 50);
        Console.WriteLine(s + "Withdraw Type" + s);
        Console.WriteLine("1.widraCash\n2.Cheque");
        string widratype = Console.ReadLine();
        switch (widratype)
        {
            case "1":
                Console.WriteLine("widra cash");
                Console.WriteLine("Enter how much amout you wan to W");
                DepositAmount = Console.ReadLine();
                mainbalance -= int.Parse(DepositAmount);
                break;
            case "2":
                Console.WriteLine("Enter cheque number");
                Cheque_number = Console.ReadLine();
                Console.WriteLine("Enter how much amout you wan to W");
                WithdrawAmount = Console.ReadLine();
                mainbalance -= int.Parse(DepositAmount);
                Console.WriteLine("Cheque");
                break;
        }
    }

    public void updateBalance()
    {
        Console.WriteLine(" Current updateBalance  ");
    }
}