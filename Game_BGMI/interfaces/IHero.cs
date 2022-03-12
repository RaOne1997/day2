// See https://aka.ms/new-console-template for more information


namespace Game_BGMI.interfaces
{
    public interface IHero : IPlayer
    {
        public void ShootEnemy(IEnemy enemy, int damage);
        public void Display();
    }


}





// Create another weapon called Bazooka
// Override the methods appropriately