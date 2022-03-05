
class Demo4tosearchlinear
{

    internal static void test()
    {
        int[] arr = new int[] { 55, 22, 22, 78, 88, 22, 88, 44, 54, 86, 23 };
        Console.WriteLine("Enter the age");
            string age = Console.ReadLine();
     

        bool Found = Searchs(arr, int.Parse(age));
        if (Found)
            Console.WriteLine("Age is Found");
        else
            Console.WriteLine( age + " Age is not present in regord");



    }

    static bool Searchs(int [] arr, int age)
    {
        bool found= false;
        foreach (int  num in arr)
        {
            if (num  == age)
            {

                found = true;
                break;
            }
        }
        return found;

    }


}



