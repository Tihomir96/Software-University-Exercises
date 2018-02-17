
using System;
using System.Linq;
using System.Reflection;

public class AmmunitionFactory : IAmmunitionFactory
{
    public AmmunitionFactory()
    {
    }

    public IAmmunition CreateAmmunition(string ammunitionName)
    {
        Type typeAmmoToCreate = Assembly.GetExecutingAssembly().GetTypes()
            .FirstOrDefault(x => x.Name.Equals(ammunitionName, StringComparison.OrdinalIgnoreCase));
        IAmmunition ammo =(IAmmunition)Activator.CreateInstance(typeAmmoToCreate);
        return ammo;
    }
    public IAmmunition CreateAmmunition(string ammunitionName,int number)
    {
        Type typeAmmoToCreate = Assembly.GetExecutingAssembly().GetTypes()
            .FirstOrDefault(x => x.Name.Equals(ammunitionName, StringComparison.OrdinalIgnoreCase));
        IAmmunition ammo = (IAmmunition)Activator.CreateInstance(typeAmmoToCreate,number);
        return ammo;
    }
   
}
