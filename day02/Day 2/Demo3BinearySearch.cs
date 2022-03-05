class Demo3BinearySearch
{
    public static void Test3()
    {

        Console.WriteLine("Enter the how many number you mant to sort");
        string lend = Console.ReadLine();
        int total = int.Parse(lend);

        int[] arr = new int[total];


        for (int i = 0; i < total; i++)
        {

            Console.WriteLine("Enter the element  0" + i);
            string number = Console.ReadLine();
            arr[i] = int.Parse(number);


        }
        Console.WriteLine("Enter the element to search");
        String value = Console.ReadLine();

        bool isfound = Binearysearch(arr, int.Parse(value));
        if (isfound)
        {
            Console.WriteLine("Found");
        }
        else
            Console.WriteLine("Not found");


    }
    private static bool Binearysearch(int[] arr, int num)
    {
        int lowindex = 0;
        int highindex = arr.Length - 1;
        while (lowindex <= highindex)
        {
            int midindex = (highindex + lowindex) / 2;
            if (num == arr[midindex])
                return true;
            else if (num < arr[midindex])
                highindex = midindex - 1;
            else if (num > arr[midindex])
                lowindex = midindex + 1;
        }
        return false;

    }
}


