class Calculationoperation
{  
    public static Double Calclate(String s)
    {
        string[] withoutSpacer = s.Split(" ");
        int anss = 0; //= int.Parse(withoutOperator[0]);

        for (int i = 0; i < withoutSpacer.Length; i++)
        {
            if (withoutSpacer[i] == "+")
            {
                anss += int.Parse(withoutSpacer[i+ 1]);
                
            }
            else if (withoutSpacer[i] == "-")
            {
                anss -= int.Parse(withoutSpacer[i+1]);
                
            }
            else if (withoutSpacer[i] == "*")
            {
                anss *= int.Parse(withoutSpacer[i+1]);
                
            }
            else if (withoutSpacer[i] == "/")
            {
                anss /= int.Parse(withoutSpacer[i+1]);
               
            }
            else if (anss == 0)
                anss = int.Parse(withoutSpacer[i]);
           
        }
        return  anss;
    }
}
