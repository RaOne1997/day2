
class menu3 
{



    public void show()
    {
        IWeapon weapon = weapons.Create();


        do
        {
            Console.Write("\nSelect action (1-switch Pistol, 2-switch Bazooka, 3-Shoot, 4-Show, 5-Hide): ");
            var keyInfo = Console.ReadKey();
            var createdWeapon = weapons.Create(keyInfo.KeyChar);

            if (createdWeapon != null)
                weapon = createdWeapon;
            else
            {
                
                Console.WriteLine("\n"+keyInfo.KeyChar);
                switch (keyInfo.KeyChar)
                {
                    case '1':
                        weapon.Show();
                        break;

                    case '2':
                        weapon.Shoot();
                        break;
                    case '3':
                        weapon.hide();
                        break;
                    case '4':
                        Environment.Exit(0);
                        break;


                }


            }


        } while (true);






    }

}