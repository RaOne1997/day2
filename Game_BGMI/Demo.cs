
using Game_BGMI.interfaces;

namespace Game_BGMI
{
    internal class Demo
    {
        public static void demo()
        {
            IWeapon weapon1 = new Pistol(6, 20);
            weapon1.Shoot();
            weapon1.Display();
            weapon1.Reload();
            weapon1.Display();

            IWeapon weapon2 = new Ak47(30, 50, ConsoleColor.Blue);
            weapon2.Shoot();
            weapon2.Display();
            weapon2.Reload();
            weapon2.Display();

            IEnemy enemy = new Enemy("RAZE", 's');
            IHero hero = new Hero("Sova",'s');


            enemy.Display();
            hero.Display();
            enemy.Move('S');
            enemy.ShootHero(hero, 25);

            enemy.GetShot(10);
            enemy.Display();
            hero.Move('S');

            hero.ShootEnemy(enemy, 25);
            hero.GetShot(10);
            hero.Display();
        }
    }
}
