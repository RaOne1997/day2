
public class CourceDEtils : ISubject
{
    string s = new string('-', 42);
    string t = new string('-', 105);
    List<Courceinfo> _courceInfo = new List<Courceinfo>();

    public void Addsubject(Courceinfo courceinfo)
    {
        _courceInfo.Add(courceinfo);
    }

    public void Addsubject()
    {

        var code = ConsoleMessage.ReadLine<int>("Enter code");
        var name = ConsoleMessage.ReadLine<string>("Enter name");
        var description = ConsoleMessage.ReadLine<string>("Enter Description");
        var courseFees = ConsoleMessage.ReadLine<double>("Enter Course Fees");
        var startDate = ConsoleMessage.ReadLine<DateTime>("Enter Course Start Date");
        Courceinfo c = new Courceinfo(code, name, description, courseFees, startDate);
        _courceInfo.Add(c);

    }
    public void DisplayAllSubjectRecord()
    {

        Console.Clear();
        ConsoleMessage.ShowHeader(s + "Module Listing Report" + s);
        ConsoleMessage.ShowHeader("|      Cource Code     |Name           |Discription           |FEE              |StartDate              |");
        ConsoleMessage.ShowHeader(t);

        foreach (var _courceInfo in _courceInfo)
        {
            ConsoleMessage.ShowColumn($"|{_courceInfo.CCode,15}|{_courceInfo.CName,-20}|" +
            $"{_courceInfo.Description,-24}|{_courceInfo.CourceFee,-17}|{_courceInfo.StartDate,-23:dd-MMM-yyyy}|");

        }
        ConsoleMessage.ShowColumn(t);
        ConsoleMessage.ShowText("Press any key to close this Window......!");
        Console.ReadKey();
        Console.Clear();
    }

    public void displaySubjectRecord()
    {
        var Ccode = ConsoleMessage.ReadLine<int>("\nEnter Subject Code ");
        Displaytable(Ccode);

    }

    public void Displaytable(int Ccode)
    {
        for (int i = 0; i <= _courceInfo.Count - 1; i++)
        {
            if (_courceInfo[i].CCode == Ccode)
            {
                ConsoleMessage.ShowHeader(s + $"  Report of  {_courceInfo[i].CName,-8}" + s);
                ConsoleMessage.ShowHeader("|Cource Code         | Cource Name         |  Description          |CourceFee        |StartDate         |");
                ConsoleMessage.ShowHeader(t);
                ConsoleMessage.ShowText($"|{_courceInfo[i].CCode,20}|{_courceInfo[i].CName,-21}|" +
                                        $"{_courceInfo[i].Description,-23}|{_courceInfo[i].CourceFee,17}|{_courceInfo[i].StartDate,18:dd-MMM-yyyy}|");
                ConsoleMessage.ShowText(t);
                break;
            }
            else
            {
                if (i == _courceInfo.Count - 1)
                {
                    ConsoleMessage.ShowHeader(s + "      Not Found     " + s);
                    ConsoleMessage.ShowHeader("|Cource Code         | Cource Name         |  Description          |CourceFee        |StartDate         |");
                    ConsoleMessage.ShowHeader(t);
                    var Q = new string(' ', 50);
                    ConsoleMessage.ShowWarning(Q + "Not Found" + Q);
                    Console.WriteLine('\a');
                    Console.ReadKey();
                    ConsoleMessage.ShowText(t);
                }
                else
                    continue;

            }
        }


    }

    public void updateSubject()
    {
        Console.Clear();
        ConsoleMessage.ShowText("--------------");
        ConsoleMessage.ShowText("|Update student Record |");
        ConsoleMessage.ShowText("--------------");
        var Ccode = ConsoleMessage.ReadLine<int>("Enter Roll Number");
        string s = new string(' ', 47);
        ConsoleMessage.ShowHeader($"{s}Old Record {s}");
        Displaytable(Ccode);

        for (int i = 0; i <= _courceInfo.Count - 1; i++)
        {
            if (_courceInfo[i].CCode == Ccode)
            {
                Console.WriteLine("Select  What do you want to update\n");
                Console.WriteLine(" 1.Cource Name\n 2.Cource Code\n 3.Description\n 4.Start Date\n 5.Course Fees\n");
                var toupdate = ConsoleMessage.ReadLine<int>("Enter Your Choise");
                switch (toupdate)
                {
                    case 1:

                        var updateName = ConsoleMessage.ReadLine<string>("Enter New Update Cource Name");
                        _courceInfo[i].CName = updateName;
                        break;
                    case 2:
                        var ccode = ConsoleMessage.ReadLine<int>("Enter New Cource Code");
                        _courceInfo[i].CCode = Ccode;
                        break;
                    case 3:
                        var Description = ConsoleMessage.ReadLine<string>("Enter New Description ");

                        _courceInfo[i].Description = Description;
                        break;
                    case 4:
                        var Startdate = ConsoleMessage.ReadLine<DateTime>("Start Date");
                        _courceInfo[i].StartDate = Startdate;
                        break;
                    case 5:
                        var courseFees = ConsoleMessage.ReadLine<double>("Enter Course Fees");

                        _courceInfo[i].CourceFee = courseFees;
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
                ConsoleMessage.ShowHeader("Record Update successfully");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            else
            {
                if (i == _courceInfo.Count - 1)
                {
                    Console.WriteLine(" NOt Found");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                    continue;

            }
        }
    }

    public void displayAllSubjectRecord()
    {
        Console.Clear();
        ConsoleMessage.ShowHeader(s + "Module Listing Report" + s);
        ConsoleMessage.ShowHeader("|      Cource Code     |Name           |Discription           |FEE              |StartDate              |");
        ConsoleMessage.ShowHeader(t);

        foreach (var _courceInfo in _courceInfo)
        {
            ConsoleMessage.ShowColumn($"|{_courceInfo.CCode,15}|{_courceInfo.CName,-20}|" +
            $"{_courceInfo.Description,-24}|{_courceInfo.CourceFee,-17}|{_courceInfo.StartDate,-23:dd-MMM-yyyy}|");

        }
        ConsoleMessage.ShowColumn(t);
    }

    public void EndrolSubject()
    {
        
    }
}

