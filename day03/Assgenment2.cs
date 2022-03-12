
class Assgenment2
{
    public static void test()
    {
        var s = new string('=', 50);
        Console.WriteLine(s + "Assigenment Day 3" + s);
        Console.WriteLine("Enter the Equation containing number and operator");
        string S = Console.ReadLine();
        Calclate(S);
    }
    public static void Calclate(String s)
    {
        string[] withoutSpacer = s.Split(" ");
        int anss = 0; //int.Parse(withoutSpacer[0]);

        for (int i = 0; i < withoutSpacer.Length; i++)
        {
            if (withoutSpacer[i] == "+")
            {
                anss += int.Parse(withoutSpacer[i + 1]);
                i++;
            }
            else if (withoutSpacer[i] == "-")
            {
                anss -= int.Parse(withoutSpacer[i + 1]);
                i++;
            }
            else if (withoutSpacer[i] == "*")
            {
                anss *= int.Parse(withoutSpacer[i + 1]);
                i++;
            }
            else if (withoutSpacer[i] == "/")
            {
                anss /= int.Parse(withoutSpacer[i + 1]);
                i++;
            }
            else
            {

                anss = int.Parse(withoutSpacer[i]);

            }

        }
        Console.WriteLine(anss);
    }
}

