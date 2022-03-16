class M416 : IWeapon
{

    public void Start()
    {
     
    }
    public void hide()
    {
        Console.WriteLine("M416 Hide");
    }

    public void Shoot()
    {
        for (int a = 1; a <= 10; a++)
        {

            Console.WriteLine("M416 Fire............");
        }
    }

    public void Show()
    {
        Console.WriteLine("M416 Pistol");
    }
}
