using day11Democode.menu;

namespace day11Democode.Canvas
{
    class Draw
    {

        public void Start()
        {
            IDrawTool selectedDrawTool = DrawToolFactory.Create();
            ICanvas selectedCanvas = CanvasFactory.Create();
            IMenu menu = new Menu();
            do
            {
                Console.WriteLine("\nDraw Menu");
                menu.Displaymenu();
                menu.Displaymenuc();
                Console.WriteLine("d.Draw");
                Console.WriteLine("u.Undo");
                Console.Write("Select a choice: ");
                var keyInfo = Console.ReadKey();
                if (menu.Keypressdrawtools(keyInfo.KeyChar))

                    selectedDrawTool = DrawToolFactory.Create(keyInfo.KeyChar);

                else if (menu.KeypressCanvas(keyInfo.KeyChar))

                    selectedCanvas = CanvasFactory.Create(keyInfo.KeyChar);

                switch (keyInfo.KeyChar)
                {
                    case 'd':
                        selectedCanvas.Draw(selectedDrawTool);
                        break;
                    case 'u':
                        selectedCanvas.Undo();
                        break;

                }

            } while (true);

        }
    }
}





