// See https://aka.ms/new-console-template for more information
namespace Game_BGMI.interfaces
{
    public interface IEnemy : IPlayer
{
    public void ShootHero(IHero hero, int damage);
    public void Display();
}
}








// Create another weapon called Bazooka
// Override the methods appropriately