using Game_BGMI.interfaces;
namespace Game_BGMI
{
    public class Hero : Player, IHero
    {
        public Hero(string Name, char StartDirection) : base(Name, StartDirection)
        {
        }

        public void Display()
        {
            Console.WriteLine($"Hero: {player_Name}, health={player_health}, facing direction={direction}");
        }
        public void GetShot(int damage)
        {
            player_health -= damage;
            Console.WriteLine($"getShot hero :{player_health} ");
        }

        public void Move(char direction)
        {
            Console.WriteLine("Move hero");
        }

        public void ShootEnemy(IEnemy enemy, int damage)
        {
            Console.WriteLine("ShootEnemy hero ");
        }
    }
}






