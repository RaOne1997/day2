using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Demo.ArctechInfo.Controls
{
    internal class Checkbox : Control
    {
        private const int TextOffset = 1;
        private const string ValidChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-=[];',.\"!@#$%^&*()_+{}:<>? ";
        private static readonly ConsoleKey[] ExitKeys =
{
        ConsoleKey.UpArrow, ConsoleKey.DownArrow,
        ConsoleKey.Enter, ConsoleKey.Escape, ConsoleKey.Tab
    };
        public string Text { get; set; } = null!;

        public Checkbox(int left, int top, int width) :
            base(left, top, width)
        {
            ForeColor = ConsoleColor.Black;
            BackColor = ConsoleColor.White;
        }

        protected override void ShowBody()
        {
            Console.Write(DisplayText);
        }

        public event EventHandler? OnClicked;



        public void Click()
        {
           // BlinkButtonForVisualEffect();

            Show();

            OnClicked?.Invoke(this, EventArgs.Empty);
        }
        private string DisplayText
        {
            get
            {
                var text = Text;

                if (string.IsNullOrEmpty(text))
                    text = "[ ]";
                else if (text.Length > Width)
                    text = text[..Width];// substring 
                                         // to padding from Right     
                return text.PadRight(Width);
            }
        }

        
        public override ConsoleKeyInfo HandleConsoleInput()
        {
            SendColorToConsole();

            TextBoxCursor textBoxCursor = new();

            var characters = DisplayText.ToCharArray();

            while (true)
            {



                Console.SetCursorPosition(Left + textBoxCursor + 1, Top);
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


    




    public class TextBoxCursor
    {
        private int _cursorPosition;
        private int _inputTextLength;

        public static implicit operator int(TextBoxCursor textBoxCursor) =>
            textBoxCursor._cursorPosition;

        public static TextBoxCursor operator ++(TextBoxCursor textBoxCursor)
        {
            return GetTextBoxCursor(textBoxCursor._cursorPosition + 1);
        }

        private static TextBoxCursor GetTextBoxCursor(int newPosition)
        {
            var newTextBoxCursor = new TextBoxCursor
            {
                _cursorPosition = newPosition,
                _inputTextLength = newPosition
            };

            return newTextBoxCursor;
        }

        public static TextBoxCursor operator --(TextBoxCursor textBoxCursor)
        {
            return GetTextBoxCursor(textBoxCursor._cursorPosition - 1);
        }

        public void MoveLeft()
        {
            if (_cursorPosition == 0)
            {
                Console.Beep();
                return;
            }

            --_cursorPosition;
        }

        public void MoveRight()
        {
            if (_cursorPosition == _inputTextLength)
            {
                Console.Beep();
                return;
            }

            ++_cursorPosition;
        }
    }
}
