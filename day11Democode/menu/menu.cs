namespace day11Democode.menu
{
    public partial class Menu
    {
        public static void Displaymenuc()
        {
            Console.WriteLine("Change Tool, (b.Brush, r.Roller, p.Pencil, n.Pen");

        }


        public static bool KeypressCanvas(char keyInfo)
        {


            if (keyInfo >= '1' && keyInfo <= '9')
            {
                return true;
            }
            return false;

        }

        public static void Displaymenu()
        {
            Console.WriteLine("\nDraw Menu");
            Console.WriteLine("Change Surface, (1.Building, 2.Paper, 3.Train, 4.Plane, 5.T.Shirt");
            Displaymenuc();
            Console.WriteLine("d.Draw");
            Console.WriteLine("u.Undo");
            Console.Write("Select a choice: ");

        }


    }



}
