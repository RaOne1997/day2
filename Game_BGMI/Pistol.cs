public class Pistol : Weapon
{
    public Pistol(int magazineCapacity, int bulletCount) : base(magazineCapacity, bulletCount)
    {
    }

    public override void HideWeapon()
    {
        Console.WriteLine("Shotting");
    }

    public override void ShowWeapon()
    {
        Console.WriteLine("Shotting");
    }
}








// Create another weapon called Bazooka
// Override the methods appropriately