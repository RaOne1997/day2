class Menu
{

    protected MenuItem SelectedMenu;
    public IStudent student = new Student();
    public ISubject subject = new Cource();
    public void Test()
    {
        student.AddstudentRecord(new Studentinfo("AAAA", "Sy", 100, DateTime.Now, 20, 50, 40, (Gender)Enum.Parse(typeof(Gender), "Male"),105));
        student.AddstudentRecord(new Studentinfo("bb", "FY", 15, DateTime.Now, 30, 60, 40, (Gender)Enum.Parse(typeof(Gender), "2"),101));
        student.AddstudentRecord(new Studentinfo("CCC", "TY", 16, DateTime.Now, 40, 60, 40, (Gender)Enum.Parse(typeof(Gender), "2"),102));
        student.AddstudentRecord(new Studentinfo("DDD", "FOUR year", 18, DateTime.Now, 50, 60, 0, (Gender)Enum.Parse(typeof(Gender), "2"),110));


        subject.Addsubject(new Courceinfo(100, "Java", "Full details", 5000d, DateTime.Now));
        subject.Addsubject(new Courceinfo(101, "html", "Full details", 10000d, DateTime.Now));
        subject.Addsubject(new Courceinfo(105, "CSS", "Full details", 21000d, DateTime.Now));
        subject.Addsubject(new Courceinfo(110, "C#", "Full details", 5000d, DateTime.Now));
        subject.Addsubject(new Courceinfo(102, "Android", "Full details", 8554, DateTime.Now));





    }


    public void Stat()
    {
        Console.WindowHeight = 50;
        Console.WindowWidth = 150;
        
        Console.SetCursorPosition(40, 0);
        ConsoleMessage.ShowHeader("College Regristration System");

        Test();
        do
        {
            Menuitems();
            switch (heady())
            {
                case MenuItem.AddStudent:
                    //Test();
                    student.AddstudentRecord();
                    break;
                case MenuItem.EditStudent:
                    student.updatestudent();
                    break;

                case MenuItem.GetAnyStudent:
                    student.displayStudentRecord();
                    break;

                case MenuItem.GetAllStudents:
                    student.DisplayAllStudent();

                    break;

                case MenuItem.AddSubject:

                    subject.Addsubject();
                    break;

                case MenuItem.EditSubject:
                    subject.updateSubject();

                    break;

                case MenuItem.GetAnySubject:
                    subject.displaySubjectRecord();

                    break;
                case MenuItem.GetAllSubjects:
                    subject.DisplayAllSubjectRecord();

                    break;

                case MenuItem.ShowStudentMarks:
                    Console.WriteLine("MArk of all ");
                    break;
                case MenuItem.Exit:
                    Console.WriteLine("Exist");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nPlease Select Proper Operation");
                    break;
            }

        } while (true);


    }
    protected void Menuitems()
    {
        ConsoleMessage.ShowMenu(" 1) Add Student\n" +
                                " 2) Edit Student\n" +
                                " 3) Get any Student\n" +
                                " 4) Get all Students\n" +
                                " 5) Add Subject\n" +
                                " 6) Edit Subject\n" +
                                " 7) Get any Subject\n" +
                                " 8) Get all Subjects\n" +
                                " 9) Show Student Marks\n" +
                                " 0) Exit");

    }
    MenuItem heady()
    {
        Console.Write("Enter your choise: ");
        var keyInfo = Console.ReadKey(true);

        if (keyInfo.KeyChar is >= '0' and <= '9')
        {

            var asciiOfKeyChar = keyInfo.KeyChar - '0';
            SelectedMenu = (MenuItem)asciiOfKeyChar;
        }
        else
            ConsoleMessage.ShowWarning("Please select Proper Selection..............");
        SelectedMenu = keyInfo.Key switch
        {
            ConsoleKey.Escape => MenuItem.Exit,
            ConsoleKey.X => MenuItem.ClearScreen,
            _ => SelectedMenu
        };

        return SelectedMenu;
    }


}
