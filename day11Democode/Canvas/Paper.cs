
namespace day11Democode.Canvas
{

    class Paper : ICanvas
    {

        public void Draw(IDrawTool drawTool)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n Paper Drawing using{drawTool.Drawaltools()}");
            Console.ResetColor();
        }

        public void Undo()
        {

        }


    }
}
