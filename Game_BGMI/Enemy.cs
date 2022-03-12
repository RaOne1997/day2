using Game_BGMI.interfaces;

namespace Game_BGMI
{
    public class Enemy : Player, IEnemy
    {
        public Enemy(string name, char direction) : base(name, direction)
        {
        }

        public void Display()
        {
            Console.WriteLine($"Enemy: {player_Name}, health={player_health}, facing direction={direction}");
        }

        public void GetShot(int damage)
        {
            player_health -= damage;
            if (player_health < 0)
            {
                player_health = 0;
                Console.WriteLine($"Enemy has died... :)");
            }
        }

        public void Move(char Direction)
        {
            Console.Write($"Enemy Originally facing: {direction}");
            direction = Direction;
            Console.WriteLine($"Enemy Now facing: {direction}");
        }

        public void ShootHero(IHero hero, int damage)
        {
            Console.Write($"About to Shooting hero. ");
            hero.Display();

            hero.GetShot(damage);

            Console.Write($"After Shooting hero. ");
            hero.Display();
        }
    }
}


////public class Enemy : Player, IEnemy
////    {
////        int _health;
////        char _direction;

////        public Enemy(string Name, char StartDirection) : base(Name, StartDirection)
////        {
////        }

////        public void Display()
////        {
////            throw new NotImplementedException();
////        }

////        public void GetShot(int damage)
////        {
////            throw new NotImplementedException();
////        }

////        public void Move(char direction)
////        {
////            throw new NotImplementedException();
////        }

////        public void ShootHero(IHero hero, int damage)
////        {
////            throw new NotImplementedException();
////        }


