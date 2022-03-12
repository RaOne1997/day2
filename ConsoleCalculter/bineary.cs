

//Culcalater culcalater = new Culcalater();
//culcalater.Statr();
class bineary
{
    public void Calculatio()
    {
        int n, j;
        int[] a = new int[10];
        Console.Write("Enter the number to convert: ");
        n = int.Parse(Console.ReadLine());
        for (j = 0; n > 0; j++)
        {
            a[j] = n % 2;
            n = n / 2;
        }
        Console.Write("Binary of the given number= ");
        for (j = a.Length -1; j >= 0; j--)
        {
            if (j == 6)
            {
                Console.Write(a[j] + " ");
            }
            else
            Console.Write(a[j]);
        }

        
        

    }
    


}