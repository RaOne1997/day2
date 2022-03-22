using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Demo.ArctechInfo.Controls
{
    internal class RadioButton : Control
    {
        private const int TextOffset = 1;
        private static readonly ConsoleKey[] ExitKeys =
{
        ConsoleKey.UpArrow, ConsoleKey.DownArrow,
        ConsoleKey.Enter, ConsoleKey.Escape, ConsoleKey.Tab
    };
        public string Text { get; set; } = null!;

        public RadioButton(int left, int top, int width) :
            base(left, top, width)
        {
            ForeColor = ConsoleColor.Black;
            BackColor = ConsoleColor.White;
        }

        protected override void ShowBody()
        {
            if (DisplayText == "[x]")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Red;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
            }

            Console.Write(DisplayText);
            Console.ResetColor();
        }

        public event EventHandler? OnClicked;



        public void Click()
        {
            Show();

            OnClicked?.Invoke(this, EventArgs.Empty);
        }



        private string DisplayText
        {
            get
            {
                var text = Text;

                if (string.IsNullOrEmpty(text))
                    text = "[x]";
                return text.PadRight(Width);
            }
        }


        public override ConsoleKeyInfo HandleConsoleInput()
        {
            SendColorToConsole();

            while (true)
            {
                Console.SetCursorPosition(Left + 1, Top);
                var keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.Spacebar:
                        Click();
                        break;
                    default:
                        {
                            if (ExitKeys.Contains(keyInfo.Key))
                            {
                                Console.ResetColor();
                                return keyInfo;
                            }

                            Console.Beep();
                            break;
                        }
                }



            }
        }
    }
}
