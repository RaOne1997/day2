

class weapons
{
    public static IWeapon Create(char key = 'p')
    {

        switch (key)
        {
            case 'p':
                return new Pistol();
           break;
            case 'm':
                return new M416();
                break;
            case 'r':
                return new Rocketlauncher();
                break;
        }
        return null;

    }



}
