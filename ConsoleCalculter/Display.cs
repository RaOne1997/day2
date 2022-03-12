
class Display
{
    public int Left, Top;
    public int Width;
    ConsoleColor ForegroundColor;
    ConsoleColor BackgroundColor;
    public void createDisplay(int left, int top, int width, ConsoleColor foregroundColor, ConsoleColor backgroungColoue)
    {
        Left = left;
        Top = top;
        Width = width;
        ForegroundColor = foregroundColor;
        BackgroundColor = backgroungColoue;
    }
    internal void ShowText(string text, string text1)
    {
        Displayshow();

        if (text == "")
            text = "0";

        if (text1 != "")
        {
            Console.SetCursorPosition(Left + Width - text.Length - 10, Top + 1);
            Console.Write("Ans : - " + text1);

        }
        else
        {

            Console.SetCursorPosition(Left + Width - text.Length - 1, Top + 3);
            Console.Write(text);
        }
      
    }

    public void Displayshow()
    {

        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Cyan;
        var s = new string(' ', Width);
        Console.SetCursorPosition(Left, Top);
        Console.WriteLine(s);
        Console.SetCursorPosition(Left, Top + 1);
        Console.WriteLine(s);
        Console.SetCursorPosition(Left, Top + 2);
        Console.WriteLine(s);
        Console.SetCursorPosition(Left, Top + 3);
        Console.WriteLine(s);
    }

    public void DisplayProgrammer()
    {

        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Cyan;
        var s = new string(' ', Width);
        Console.SetCursorPosition(Left + Width + 5, Top);
        Console.WriteLine(s);
        Console.SetCursorPosition(Left + Width + 5, Top + 1);
        Console.WriteLine(s);
        Console.SetCursorPosition(Left + Width + 5,   Top + 2);
        Console.WriteLine(s);
        Console.SetCursorPosition(Left + +Width + 5, Top + 3);
        Console.WriteLine(s);
    }
}


