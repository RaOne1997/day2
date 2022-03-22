using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Demo.ArctechInfo.Controls
{
    internal class DropDown : Control
    {
       

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

           // AddState();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(Left, Top);
            Console.WriteLine("----------------------------");

            //foreach (var name in state)
            //{
            //    Console.SetCursorPosition(Left, Top + 1);
            //    Console.WriteLine($"|          {name}         |");

            //}

            //Console.WriteLine("|                          |");
            //Console.SetCursorPosition(Left, Top+2);
            //Console.WriteLine("|                          |");
            Console.SetCursorPosition(Left, Top + 3);
            Console.WriteLine("---------------------------");
            Console.ResetColor();


        }
        public void Click()
        {
            //BlinkButtonForVisualEffect();
            Dropdowns();

            OnClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BlinkButtonForVisualEffect()
        {
            Console.SetCursorPosition(Left, Top);

            SendColorToConsole(ConsoleColor.Black, ConsoleColor.Black);
            Console.Write(Text);
            Thread.Sleep(100);

            Console.ResetColor();
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
                        Click();
                        break;
                    default:
                        {
                            if (ExitKeys.Contains(keyInfo.Key))
                            {
                                Console.ResetColor();
                                Console.SetCursorPosition(Left, Top + 1);
                                return keyInfo;
                            }

                           // Console.Beep();
                            break;
                        }
                }
            }
        }
    }
}





//List<string> state = new List<string>();

////public void AddState()
////{
////    state.Add("MAharashtr");
////    state.Add("RJ");
////    state.Add("Goa");
////    state.Add("KA");


////}