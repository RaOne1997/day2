
using Game_BGMI.interfaces;
public abstract class Weapon : IWeapon
{
    int MagazineCapacity;
    int RemainingBullets;
    int BulletsInsideWeapon;
    public Weapon(int magazineCapacity, int bulletCount)
    {
        MagazineCapacity = magazineCapacity;
        RemainingBullets = bulletCount;
        BulletsInsideWeapon = MagazineCapacity;
    }
    public abstract void HideWeapon();
    public abstract void ShowWeapon();
    public virtual void Shoot()
    {
        RemainingBullets -= 1;
    }
    public virtual void Reload()
    {
        if (MagazineCapacity == 0)
        {
            Console.WriteLine("magins Empty");
        }
        else
            RemainingBullets = MagazineCapacity;
    }
    public virtual void Display()
    {
        Console.WriteLine($"Weapon: MagazineCapacity: {MagazineCapacity}, RemainingBullets: {RemainingBullets}");
    }

    public virtual void Shoot(int bullets)
    {
        RemainingBullets -= bullets;
    }
}








// Create another weapon called Bazooka
// Override the methods appropriately