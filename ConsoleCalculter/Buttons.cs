// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*Q.What entities are needed?
A. Calculator
B. DisplayBox
C. Button
*/

class Buttons
{

    public int Left, Top;
    public string Text;
    public   void createbtn(int left, int top, string text)
    {
        Left = left;
        Top = top;
        Text = text;

    }

    public  void Setcolour(ConsoleColor ForegroundColor, ConsoleColor BackgroungColoue)
    {

        Console.ForegroundColor = ForegroundColor;
        Console.BackgroundColor = BackgroungColoue;
    }
    public void Buttonshow()
    {
         Console.SetCursorPosition(Left, Top);
        Console.Write("      ");
        Console.SetCursorPosition(Left, Top + 1);
        var displayText = Text.Length == 1 ? $"{Text} " : Text;
        Console.Write($"  {displayText}  ");
        Console.SetCursorPosition(Left, Top + 2);
        Console.Write("      ");
    }



}


