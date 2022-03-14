//Console.WriteLine("Hello, World!");
//Customer.Start();

class Account
{
    private string AccountNo;
    public string Name;
    private string Accounttype;
    int type;
    public void Userinformation()
    {
        var s = new string('-', 50);
        Console.WriteLine("Enter Name of Account Holder");
        Name = Console.ReadLine();
        Console.WriteLine("Enter Account Number");
        AccountNo = Console.ReadLine();
        Console.WriteLine(s + $"Welcome {Name}" + s);
        Console.WriteLine("1.Saving\n2.Current");
        Console.Write("Select what you want to perform: ");
        Accounttype = Console.ReadLine();
        Accounttypes(Accounttype);
        
        ConsoleKeyInfo keyInfo;
        do
        {
            Console.WriteLine(s + "Welcome" + s);
            Console.Write("Select what you want to perform: ");
            if (Accounttype =="1")
                Console.WriteLine("\n1.withdraw\n2.deposit\n3.view Intress\n4.Exit");
            else
                Console.WriteLine("1.withdraw\n2.deposit\n3.Exit");
            string operation = Console.ReadLine();
            Operations(int.Parse(operation));
            keyInfo = Console.ReadKey(true);
        } while (keyInfo.Key != ConsoleKey.Escape);
    }
    public void Operations(int operation)
    {
        Saving savingaccount = new Saving();
        Current Currentaccount = new Current();
        switch (operation)
        {

            case 1:
                if (type == 1)
                {
                    savingaccount.Moneywithdraw();
                    savingaccount.updateBalance(Name);

                }
                else if (type == 2)
                {
                    Currentaccount.Moneywithdraw();
                    Currentaccount.updateBalance(Name);
                }
                break;
            case 2:

                if (type == 1)
                {
                    savingaccount.MoneyDeposit();
                    savingaccount.updateBalance(Name);
                }
                else if (type == 2)
                {
                    Currentaccount.MoneyDeposit();
                    Currentaccount.updateBalance(Name);
                }
                break;
            case 3:

                if (Accounttype == "1")
                {
                    savingaccount.CalculateInterest();
                    savingaccount.updateBalance(Name);
                }
                else
                {
                    Console.Error.WriteLine("Please press Esc to exit");
                    return;
                }
                break;
                case 4:
                Console.Error.WriteLine("Please press Esc to exit");
                Environment.Exit(0);
                break;

            default:
                Console.Error.WriteLine("Please select proper operartion");
                break;
        }
    }
    public void Accounttypes(string AccountType)
    {
        if (AccountType == "1")
            type = 1;
        else if (AccountType == "2")
            type = 2;
        else
            type = 0;
    }

}

