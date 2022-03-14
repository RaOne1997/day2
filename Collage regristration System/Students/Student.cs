
class Student : IStudent
{
    protected int total = 0;
    string s = new string('-', 47);
    string t = new string('-', 115);
    List<Studentinfo> Studentinfos = new List<Studentinfo>();
    List<Courceinfo> Studentendrol = new List<Courceinfo>();


    public void AddstudentRecord(Studentinfo studentinfo)
    {
        Studentinfos.Add(studentinfo);
    }

    public void DisplayAllStudent()
    {
        Console.Clear();
        ConsoleMessage.ShowHeader(s + "Module Listing Report" + s);
        ConsoleMessage.ShowHeader("|      Roll     |Name              |Class            |Gender           |BirthDate            |       Total        |");
        ConsoleMessage.ShowHeader(t);
        foreach (var studentinfo in Studentinfos)
        {
            total = studentinfo.M1 + studentinfo.M2 + studentinfo.M3;
            ConsoleMessage.ShowColumn($"|{studentinfo.RollNo,15}|{studentinfo.Name,-20}|" +
      $"{studentinfo.Class,-15}|{studentinfo._gender,-17}|{studentinfo.DOB,-21:dd-MMM-yyyy}|{total,20:N}|");

        }
        ConsoleMessage.ShowColumn(t);
        ConsoleMessage.ShowText("Press any key to close this Window......!");
        Console.ReadKey();
        Console.Clear();

    }
    public void AddstudentRecord()  //Case 1:
    {
        Console.Clear();
        ConsoleMessage.ShowText("--------------");
        ConsoleMessage.ShowText("|Add Student |");
        ConsoleMessage.ShowText("--------------");
        int i = 1;
        var Name1 = ConsoleMessage.ReadLine<string>("Enter Student Name");
        var Class = ConsoleMessage.ReadLine<string>("Class");
        var Roll = ConsoleMessage.ReadLine<int>("Roll No");
        var Gen = ConsoleMessage.ReadLine<string>("Gender");
        var DOB = ConsoleMessage.ReadLine<DateTime>(" Date Of Birth");
        var M11 = ConsoleMessage.ReadLine<int>($"Makr of {i} Subject");
        var M22 = ConsoleMessage.ReadLine<int>($"Makr of {i + 1} Subject");
        var M33 = ConsoleMessage.ReadLine<int>($"Makr of {i + 2} Subject");
        Gender gender = (Gender)Enum.Parse(typeof(Gender), Gen);
        var yn = ConsoleMessage.ReadLine<string>($"Do you want to add Cource (y/n)");
        if (yn == "y")
        {
            Menu menu1 = new Menu();
            menu1.Test();
            menu1.subject.displayAllSubjectRecord();
            var Subject = ConsoleMessage.ReadLine<string>($"Enter Subject Code");
            Subject = Subject +',';
            string[] subjectcode = Subject.Split(',');
            menu1.subject.Displaytable(int.Parse(subjectcode[0]));


        }

        Studentinfo student = new Studentinfo(Name1, Class, Roll, DOB, M11, M22, M33, gender);
        Studentinfos.Add(student);
        ConsoleMessage.ShowHeader("Record saved successfully");
        Console.ReadKey();
        Console.Clear();
    }
    public void displayStudentRecord()  //Case 3:
    {

        var RollNO = ConsoleMessage.ReadLine<int>("\nEnter Roll Number of Student ");

        Displaytable(RollNO);



    }

    public void updatestudent() // Case 2:
    {
        Console.Clear();
        ConsoleMessage.ShowText("--------------");
        ConsoleMessage.ShowText("|Update student Record |");
        ConsoleMessage.ShowText("--------------");
        var RollNO = ConsoleMessage.ReadLine<int>("Enter Roll Number");
        string s = new string(' ', 52);
        ConsoleMessage.ShowHeader($"{s}Old Record {s}");
        Displaytable(RollNO);
        for (int i = 0; i <= Studentinfos.Count - 1; i++)
        {
            if (Studentinfos[i].RollNo == RollNO)
            {
                Console.WriteLine("Select  What do you want o update\n");
                Console.WriteLine(" 1.Name\n 2.Class\n 3.Roll\n 4.Birthday\n 5.Gender\n");
                var toupdate = ConsoleMessage.ReadLine<int>("Enter Your Choise");
                switch (toupdate)
                {
                    case 1:

                        var updateName = ConsoleMessage.ReadLine<string>("Enter New Update Name");
                        Studentinfos[i].Name = updateName;
                        break;
                    case 2:
                        var updateClass = ConsoleMessage.ReadLine<string>("Enter New Update Class");
                        Studentinfos[i].Class = updateClass;
                        break;
                    case 3:
                        var updateRoll = ConsoleMessage.ReadLine<int>("Enter New Update Roll");

                        Studentinfos[i].RollNo = updateRoll;
                        break;
                    case 4:
                        var DOB = ConsoleMessage.ReadLine<DateTime>("Gender");
                        Studentinfos[i].DOB = DOB;
                        break;
                    case 5:
                        var Gen = ConsoleMessage.ReadLine<string>("Gender");
                        Gender gender = (Gender)Enum.Parse(typeof(Gender), Gen);
                        Studentinfos[i]._gender = gender;
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
                if (i == Studentinfos.Count - 1)
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
    public void Displaytable(int RollNO)
    {
        for (int i = 0; i <= Studentinfos.Count - 1; i++)
        {
            if (Studentinfos[i].RollNo == RollNO)
            {
                ConsoleMessage.ShowHeader(s + $" Report of  {Studentinfos[i].Name,-9}" + s);
                ConsoleMessage.ShowHeader("|Roll           |Name              |Class            |Gender           |BirthDate            |       Total        |");
                ConsoleMessage.ShowHeader(t);
                total = Studentinfos[i].M1 + Studentinfos[i].M2 + Studentinfos[i].M3;
                ConsoleMessage.ShowText($"|{Studentinfos[i].RollNo,15}|{Studentinfos[i].Name,-20}|" +
                    $"{Studentinfos[i].Class,-15}|{Studentinfos[i]._gender,-17}|{Studentinfos[i].DOB,-21:dd-MMM-yyyy}|{total,20:N}|");
                ConsoleMessage.ShowText(t);
                break;
            }
            else
            {
                if (i == Studentinfos.Count - 1)
                {
                    ConsoleMessage.ShowText(s + "      Not Found     " + s);
                    ConsoleMessage.ShowText("|Roll           |Name              |Class            |Gender           |BirthDate        | Total              |");
                    ConsoleMessage.ShowText(t);
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
}