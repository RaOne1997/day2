class Culcalater
{

    Display display;
    Buttons buttonPercent,
        button_ClearEverything, button_Clear, button_Back, button_Reciprocal,
        button_Square, buttons_root, buttons_division, buttons_ADD,
        buttons_Sub, buttons_MULt, buttons_num1, buttons_num2,
        buttons_num3, buttons_num4, buttons_num5, buttons_num6,
        buttons_num7, buttons_num8, buttons_num9, buttons_num0, buttons_blank1, buttons_blank2, buttons_Dot, buttons_blank4;
    MathsKeyHandler maths;
    public void Statr()
    {
        Console.WindowHeight = 50;
        Console.WindowWidth = 100;
        Displaybackgroung();
        ShowDisplay();
        Displaykeypad();
        // Displaybineary();
        maths = new MathsKeyHandler();
        maths.StartCheckingKeys(display);

    }
    private void Displaybineary()
    {
        bineary bineary = new bineary();
        bineary.Calculatio();
    }

    private Buttons CreateAButton(int left, int top, string text)
    {
        var button = new Buttons();
        button.createbtn(left, top, text);
        button.Setcolour(ConsoleColor.Black, ConsoleColor.Gray);
        button.Buttonshow();

        return button;
    }
    private void Displaykeypad()
    {
        buttonPercent = CreateAButton(20, 9, "%");
        button_ClearEverything = CreateAButton(27, 9, "CE");
        button_Clear = CreateAButton(34, 9, "C");
        button_Back = CreateAButton(41, 9, "<");

        button_Reciprocal = CreateAButton(20, 13, "/x");
        button_Square = CreateAButton(27, 13, "x2");
        buttons_root = CreateAButton(34, 13, "x3");
        buttons_division = CreateAButton(41, 13, "/");

        buttons_ADD = CreateAButton(20, 17, "7"); //change   + tyo 7
        buttons_Sub = CreateAButton(27, 17, "9");
        buttons_MULt = CreateAButton(34, 17, "9");
        buttons_num1 = CreateAButton(41, 17, "*"); //change 1  to *

        buttons_num2 = CreateAButton(20, 21, "4");
        buttons_num3 = CreateAButton(27, 21, "5");
        buttons_num4 = CreateAButton(34, 21, "6");
        buttons_num5 = CreateAButton(41, 21, "-"); //change 5 to -

        buttons_num6 = CreateAButton(20, 25, "1");
        buttons_num7 = CreateAButton(27, 25, "2");
        buttons_num9 = CreateAButton(34, 25, "3");
        buttons_num9 = CreateAButton(41, 25, "+"); // change 9 to +

        buttons_blank1 = CreateAButton(20, 29, "+-");
        buttons_num0 = CreateAButton(27, 29, "0");
        buttons_Dot = CreateAButton(34, 29, ".");
        buttons_blank4 = CreateAButton(41, 29, "="); // change 9 to +

    }

    private void ShowDisplay()
    {
        display = new Display();

        display.createDisplay(20, 4, 27, ConsoleColor.Black, ConsoleColor.Cyan);
        display.Displayshow();
       // display.DisplayProgrammer(); 
        Console.ResetColor();
    }
    private void Displaybackgroung()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;

        var s = new string(' ', 34);

        for (int row = 2; row <= 33; row++)
        {
            Console.SetCursorPosition(17, row);
            Console.Write(s);
        }
        Console.SetCursorPosition(21, 3);
        Console.Write("Abhijeet  CALCULATOR");
        Console.ResetColor();
    }
}








