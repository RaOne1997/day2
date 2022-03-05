// See https://aka.ms/new-console-template for more information

class Demo2Palandrom
{

    public static void test(string[] args)
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();

        if (CheckPalandrom(s))
            Console.WriteLine(s + ": " + "Is palndrom ");
        else
            Console.WriteLine(s + ": " + "Is Not palndrom ");

        if (CheckPalandrom("runnur"))
            Console.WriteLine("runnur : " + "Is palndrom ");
        else
            Console.WriteLine("runnur" + ": " + "Is Not palndrom ");
    }
    public static bool CheckPalandrom(string s)
    {
        int sIndex = 0;
        int eIndex = s.Length - 1;
        while (sIndex < eIndex)
        {
            if (s[sIndex++] != s[eIndex--])
                return false;
        }
        return true;
    }
}
