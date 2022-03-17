using day11Democode.menu;
namespace day11Democode.Canvas
{
    class Draw
    {
        public static void Start()
        {
            IDrawTool selectedDrawTool = DrawToolFactory.Create();
            ICanvas selectedCanvas = CanvasFactory.Create();
            do
            {
                Menu.Displaymenu();
                var keyInfo = Console.ReadKey();
                var (canvas , tool) = MenuFactory.Keypressdrawtools(keyInfo);
                if (tool != null)
                    selectedDrawTool = tool;
                if (canvas != null)
                    selectedCanvas = canvas;
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