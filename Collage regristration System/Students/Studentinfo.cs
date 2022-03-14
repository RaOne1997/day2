public class Studentinfo
{
    public string Name;
    public string Class;
    public int RollNo;
    public  DateTime DOB;
    public int M1;
    public int M2;
    public int M3;
    public Gender _gender;
    public int subjectcode;


    public Studentinfo(string name, string @class, int rollNo, DateTime dOB, int m1, int m2, int m3, Gender gender,int _subjectcode)
    {
        Name = name;
        Class = @class;
        RollNo = rollNo;
        M1 = m1;
        M2 = m2;
        M3 = m3;
        DOB = dOB;
        _gender = gender;
        subjectcode = _subjectcode;

    }
    
}
