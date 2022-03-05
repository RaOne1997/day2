
class Assgenment2
{
    public static void test()
    {
        Console.WriteLine("Equation containing number and operator");
        string S = Console.ReadLine();
        Console.WriteLine(S);
        Calclate(S);
    }
    public static void Calclate(String s)
    {
        string[] withoutSpacer= s.Split(" ");
        int anss = 0 ; //= int.Parse(withoutOperator[0]);

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
                anss = int.Parse(withoutSpacer[i]);
                i++;
        }
        Console.WriteLine(anss);
    }
}

