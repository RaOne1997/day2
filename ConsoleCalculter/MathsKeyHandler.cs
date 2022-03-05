internal class MathsKeyHandler
{
    string buffer = "";

    internal void StartCheckingKeys(Display displayBox)
    {
        ConsoleKeyInfo keyInfo;

        do
        {
            double ans = 0;
            keyInfo = Console.ReadKey(true);    // Why is the purpose of true

            if (IsNumaric(keyInfo.KeyChar))
                NumberKeyPressed(keyInfo.KeyChar);
            else if (keyInfo.KeyChar == '.')
                DotKeyPressed();
            else if (keyInfo.Key == ConsoleKey.Backspace)
                BackSpacePressed();
            else if (IsOperator(keyInfo.KeyChar))
                Sign(keyInfo.KeyChar);
            else if (keyInfo.Key == ConsoleKey.Spacebar)
                NumberKeyPressed(keyInfo.KeyChar);
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                ans = Calclate(buffer);
                displayBox.ShowText(ans.ToString());
            }
            else
                continue;

            if (ans == 0)
                displayBox.ShowText(buffer);

        } while (keyInfo.Key != ConsoleKey.Escape);
    }

    private void NumberKeyPressed(char keyChar)
    {
        buffer += keyChar;
    }

    private void Sign(char keyChar)
    {

        buffer += " " + keyChar + " ";
    }

    private void BackSpacePressed()
    {
        if (buffer != "")
            buffer = buffer.Substring(0, buffer.Length - 1);
        else
            Console.Write('\a');
    }

    private void DotKeyPressed()
    {
        if (buffer.Contains('.'))
            Console.Write('\a');
        else
            buffer += '.';
    }
    private static double Calclate(String s)
    {
        string[] withoutSpacer = s.Split(" ");
        int anss = 0; //= int.Parse(withoutOperator[0]);

        for (int i = 0; i < withoutSpacer.Length; i++)
        {
            if (withoutSpacer[i] == "+")
            {
                anss += int.Parse(withoutSpacer[i + 1]);

            }
            else if (withoutSpacer[i] == "-")
            {
                anss -= int.Parse(withoutSpacer[i + 1]);

            }
            else if (withoutSpacer[i] == "*")
            {
                anss *= int.Parse(withoutSpacer[i + 1]);

            }
            else if (withoutSpacer[i] == "/")
            {
                anss /= int.Parse(withoutSpacer[i + 1]);

            }
            else if (anss == 0)
                anss = int.Parse(withoutSpacer[i]);

        }
        return anss;
    }

    private bool IsOperator(char keyChar)
    {
        return keyChar == '+' || keyChar == '-' || keyChar == '*'
                || keyChar == '/';
    }

    private bool IsNumaric(char keyChar)
    {
        return keyChar >= '0' && keyChar <= '9';
    }

}
