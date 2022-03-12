namespace Game_BGMI
{
  public class Player
    {
        protected string player_Name;
        protected int player_health;
        protected char direction;
        public Player(string Name, char StartDirection)
        {
            player_health = 100;
            player_Name = Name;
            direction = StartDirection;

        }



    }

}