
namespace day11Democode.Canvas
{

    class Train : ICanvas
    {

        public void Draw(IDrawTool drawTool)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n Train Drawing using{drawTool.Drawaltools()}");

            Console.ResetColor();
        }

        public void Undo()
        {

        }
    }
}



