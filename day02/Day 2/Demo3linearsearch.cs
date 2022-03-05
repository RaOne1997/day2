// See https://aka.ms/new-console-template for more information

//Demo1Commandlineargs.test(args);
class Demo3linearsearch
{


    public static void tests()
    {
        string[] fruits = new string[]
                {
                            "Orange",
                            "mango",
                            "Banana",
                };

        Console.Write("Enter a fruit to search: ");
        string fruitToSearch = Console.ReadLine();
        if (IsFound(fruits, fruitToSearch))
            Console.WriteLine( fruitToSearch +"Found");
        else
            Console.WriteLine(fruitToSearch + "Not Found");
    }
    static bool IsFound(string[] fruits, string fruitToSearch)
    {
        foreach (string fruit in fruits)
        {
            if (fruitToSearch == fruit)
            {
                return true;
            }
        }

        return false;
    }


}