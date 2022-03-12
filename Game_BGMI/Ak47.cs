public class Ak47 : Weapon
{
    ConsoleColor BarelColor;
    bool allowSilencer;

    public Ak47(int magazineCapacity, int bulletCount, ConsoleColor barelColor) : base(magazineCapacity, bulletCount)
    {
        BarelColor = barelColor;
        allowSilencer = false;
    }
    public override void Shoot()
    {
        for (int i = 1; i <= 10; i++)
        {
            base.Shoot();
            Console.WriteLine($"Ak47 Fire  : 1");
        }
    }
    public override void HideWeapon()
    {
        Console.WriteLine("Hide AK47");
    }
    public override void ShowWeapon()
    {
        Console.WriteLine("Show AK47 ");

    }

    public override void Display()
    {
        if (allowSilencer)
        {

            Console.BackgroundColor = BarelColor;
            base.Display();
            Console.WriteLine($"Silancer is allow ? :{allowSilencer}");
            Console.ResetColor();
        }
        else
        {

            base.Display();
            Console.WriteLine($"Silancer is allow ? :{allowSilencer}");
            Console.ResetColor();
        }
    }
}








// Create another weapon called Bazooka
// Override the methods appropriately