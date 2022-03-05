class Assigenment1
{
    public static void lengthString()
    {

        Console.WriteLine("Enter A Sting ");
        string A = Console.ReadLine();
        Console.WriteLine("lenght of String " + A.Length);
        DisplayOccurances(A);
        DisplayReverse(A);
    }
    public static void DisplayReverse(string originalString)
    {
        string reverseString = string.Empty;
        for (int i = originalString.Length - 1; i >= 0; i--)
        {
            reverseString += originalString[i];
        }
        Console.Write($"Reverse String is : {reverseString} ");
        Console.ReadKey();
    }
    public static void DisplayOccurances(string name)
    {
        char[] alphabets = new char[26];
        int[] letterCount = new int[26];
        int countTestesd = 0;
        for (int i = 0; i < name.Length - 1; i++)
        {
            int countChar = 1;
            bool isCharTested = false;
            for (int j = 0; j < alphabets.Length - 1; j++)
            {
                if (name[i] == alphabets[j])
                {
                    isCharTested = true;
                    break;
                }
            }
            if (!isCharTested)
            {
                alphabets[countTestesd] = name[i];

                for (int k = i + 1; k < name.Length - 1; k++)
                {
                    if (name[i] == name[k])
                    {
                        countChar++;
                    }
                }
                letterCount[countTestesd] = countChar;
                countTestesd++;

            }
            else
            {
                continue;
            }
        }

        for (int i = 0; i < alphabets.Length - 1; i++)
        {
            if (!char.IsLetter(alphabets[i]))
            {
                continue;
            }
            Console.WriteLine(alphabets[i] + "-" + letterCount[i]);
        }
    }
}



