
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
