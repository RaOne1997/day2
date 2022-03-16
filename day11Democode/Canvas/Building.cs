namespace day11Democode.Canvas
{
    class Building : ICanvas
    {


        public void Draw(IDrawTool drawTool)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\n Building Drawing using {drawTool.Drawaltools()}");
            Console.ResetColor();
        }

        public void Undo()
        {

        }
    }

}



