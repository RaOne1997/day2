// See https://aka.ms/new-console-template for more information
namespace Game_BGMI.interfaces
{
    public interface IPlayer
    {
        public void GetShot(int damage);
        public void Move(char direction); // N, E, W, S        
    }

}







// Create another weapon called Bazooka
// Override the methods appropriately