//// See https://aka.ms/new-console-template for more information
class demo5Short
{
    public static void test()
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
        Console.Write("Original array: ");
        Display(arr);

        Sort(arr, true);
        Console.Write("Sorted ascending array: ");
        Display(arr);

        Sort(arr, false);
        Console.Write("Sorted descending array: ");
        Display(arr);

        void Sort(int[] arr, bool ascending)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (ascending)
                    {
                        if (arr[j] < arr[i])
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                    else
                    {
                        if (arr[j] > arr[i])
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
        }

        void Display(int[] arr)
        {
            foreach (var num in arr)
            {
                Console.Write(num + ",");
            }
            Console.WriteLine();
        }
    }
}






