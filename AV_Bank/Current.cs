class Current : Account, bankoperation
{
    protected static double mainbalance = 0d;
    protected static string DepositAmount = "0";
    protected static string WithdrawAmount = "0";
    protected int penaltyAmount = 200;
    double minwidraamount;
    protected string Cheque_number;
    public void MoneyDeposit()
    {
        Console.WriteLine("Enter how much amout you wan to Deposit");
        DepositAmount = Console.ReadLine();
        mainbalance += int.Parse(DepositAmount);
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
                WithdrawAmount = Console.ReadLine();
                minwidraamount = mainbalance - int.Parse(WithdrawAmount);


                if (minwidraamount <= 250)
                {
                    double checkbalance = mainbalance - 250;
                    if (checkbalance < 0)
                        Console.WriteLine($"Your balance is below minimum balance.you Can't Widra");
                    else
                        Console.WriteLine($"Your balance is below minimum balance.you Cant Widra: {checkbalance}");
                }
                else
                    mainbalance -= int.Parse(WithdrawAmount);
                break;
            case "2":
                Console.WriteLine("Enter cheque number");
                Cheque_number = Console.ReadLine();
                Console.WriteLine("Enter how much amout you wan to W");
                WithdrawAmount = Console.ReadLine();
                if (minwidraamount <= 250)
                {
                    double checkbalance = mainbalance - 250;
                    if (checkbalance < 0)
                        Console.WriteLine($"Your balance is below minimum balance.you Can't Widra");
                    else
                        Console.WriteLine($"Your balance is below minimum balance.you Cant Widra: {checkbalance}");

                }
                else
                    mainbalance -= int.Parse(WithdrawAmount);
                break;
        }


    }

    public void updateBalance(string name)
    {
        Console.WriteLine($"Balance of {name} is {mainbalance}");

    }
}