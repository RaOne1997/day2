namespace day11Democode.menu
{
    public class Menu : IMenu
    {
       

        public  bool Keypressdrawtools(char keyInfo)
        {
            if (keyInfo >= 'a' && keyInfo <= 'z')
            {
                if (keyInfo != 'd' && keyInfo != 'd')

                    return true;
            }
            return false;

        }
        public  void Displaymenuc()
        {
            Console.WriteLine("Change Tool, (b.Brush, r.Roller, p.Pencil, n.Pen");

        }


        public  bool KeypressCanvas(char keyInfo)
        {


            if (keyInfo >= '1' && keyInfo <= '6')
            {
                return true;
            }
            return false;

        }

        public  void Displaymenu()
        {

            Console.WriteLine("Change Surface, (1.Building, 2.Paper, 3.Train, 4.Plane, 5.T.Shirt");

        }


    }



}
