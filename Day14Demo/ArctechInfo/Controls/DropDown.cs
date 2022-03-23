using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Demo.ArctechInfo.Controls
{
    internal class DropDown : Control
    {
        int Top2 ;

        List<string> state = new List<string>();

        public void AddState()
        {
            state.Add("MAharashtr");
            state.Add("RJ");
            state.Add("Goa");
            state.Add("KA");
            state.Add("MP");
            state.Add("Ap");
        }

        private const int TextOffset = 1;

        private static readonly ConsoleKey[] ExitKeys =
        {
            ConsoleKey.LeftArrow, ConsoleKey.RightArrow,
            ConsoleKey.UpArrow, ConsoleKey.DownArrow,
            ConsoleKey.Enter, ConsoleKey.Escape, ConsoleKey.Tab
         };

        public string Text { get; }

        public event EventHandler? OnClicked;

        public DropDown(string text, int left, int top, int width = 0) :
            base(left, top, Math.Max(width, text.Length + 2))
        {
            Text = $"[{text}]";
            Left = left;
            Top = top;

            ForeColor = ConsoleColor.Black;
            BackColor = ConsoleColor.Cyan;
        }

        protected override void ShowBody()
        {
            Console.Write(Text);
        }
        public void Dropdowns()
        {

            AddState();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Top2 = Top;
            Console.SetCursorPosition(Left, Top2);
            Console.WriteLine("----------------------------");

            foreach (var name in state)
            {
                Console.SetCursorPosition(Left, Top2 + 1);
                Console.WriteLine($"|{name,-25}|\n");
                Top2++;


            }
            Console.SetCursorPosition(Left, Top2 + 1);
            Console.WriteLine("---------------------------");

            Console.SetCursorPosition(Left, Top);
            Console.ResetColor();


        }
        public void Click()
        {
            //BlinkButtonForVisualEffect();
            Dropdowns();

            OnClicked?.Invoke(this, EventArgs.Empty);
        }
        public override ConsoleKeyInfo HandleConsoleInput()
        {
            SendColorToConsole();

            while (true)
            {
                Console.SetCursorPosition(Left + TextOffset, Top);
                var keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.Spacebar:
                        if (state.Count == 0)
                        {
                            Click();
                        }
                        break;
                    case ConsoleKey.Enter:
                       
                            Top2 -= Top;
                        
                        
                        break;
                    case ConsoleKey.DownArrow:
                        if (Top != Top2 && state.Count != 0  )
                        {
                            Console.SetCursorPosition(Left , Top++);
                            Console.ResetColor();
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (Top != Top2 - state.Count && state.Count != 0)
                        {
                            Console.SetCursorPosition(Left, Top--);
                            Console.ResetColor();
                        }
                        break;
                    default:
                        {
                        }
                        break;
                }

            }
        }
    }
}







