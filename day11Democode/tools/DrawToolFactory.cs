namespace day11Democode
{
    class DrawToolFactory
    {
      
        public static IDrawTool Create(char key = 'b')
        {

            switch (key)
            {
                case 'b':
                    return new Brush();

                case 'r':
                    return new Roller();
                case 'p':
                    return new Pencil();
                case 'n':
                    return new Pen();
            }
            return null;
        }


    }
}





