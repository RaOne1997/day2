//Student student = new Student();
//student.AddstudentRecord();
Menu menu = new Menu();
menu.Stat();

public class Courceinfo
{
    public string CName;
    public int CCode;
    public DateTime StartDate;
    public Fee CourceFee;
    public string Description;

    public Courceinfo(int cCode, string cName, string description, Fee courceFee, DateTime startDate)
    {
        CName = cName;
        CCode = cCode;
        Description = description;
        StartDate = startDate;
        CourceFee = courceFee;
    }



}
public class CourceDEtils : ISubject
{
    string s = new string('-', 41);
    string t = new string('-', 103);
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

    public void displayAllSubjectRecord()
    {

        Console.Clear();
        ConsoleMessage.ShowHeader(s + "Module Listing Report" + s);
        ConsoleMessage.ShowHeader("|      Cource Code     |Name           |Discription           |FEE              |StartDate            |");
       
        ConsoleMessage.ShowHeader(t);

        foreach (var _courceInfo in _courceInfo)
        {
            ConsoleMessage.ShowColumn($"|{_courceInfo.CCode,15}|{_courceInfo.CName,-20}|" +
            $"{_courceInfo.Description,-24}|{_courceInfo.CourceFee,-17}|{_courceInfo.StartDate,-21:dd-MMM-yyyy}|");

        }
        ConsoleMessage.ShowColumn(t);
        ConsoleMessage.ShowText("Press any key to close this Window......!");
        Console.ReadKey();
        Console.Clear();
    }

    public void displaySubjectRecord()
    {

    }

    public void updateSubject()
    {
        throw new NotImplementedException();
    }
}