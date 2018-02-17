using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

public abstract class Soldier : ISoldier
{
    private IWareHouse wareHouse;
    protected Soldier(string name, int age, double experience, double endurance)
    {
        this.Name = name;
        this.Age = age;
        this.Experience = experience;
        this.Endurance = endurance;
    }
    public string Name { get; protected set; }
    public int Age { get; protected set; }
    public double Experience { get; protected set; }
    public double Endurance { get; protected set; }
    public double OverallSkill { get; protected set; }
    public IDictionary<string, IAmmunition> Weapons { get; }
    
    protected abstract IReadOnlyList<string> WeaponsAllowed { get; }

    public int Power { get; set; }


    public int SuccessMissionCounter { get; set; }


    public void Regenerate ()
    {
        
    }

    public bool ReadyForMission(IMission mission)
    {
        if (this.Endurance < mission.EnduranceRequired)
        {
            return false;
        }

        bool hasAllEquipment = this.Weapons.Values.Count(weapon => weapon == null) == 0;

        if (!hasAllEquipment)
        {
            return false;
        }

        return this.Weapons.Values.Count(weapon => weapon.WearLevel <= 0) == 0;
    }

    public void CompleteMission(IMission mission)
    {
        
    }

    //private void AmmunitionRevision(double missionWearLevelDecrement)
    //{
    //    IEnumerable<string> keys = this.Weapons.Keys.ToList();
    //    foreach (string weaponName in keys)
    //    {
    //        this.Weapons[weaponName].DecreaseWearLevel(missionWearLevelDecrement);

    //        if (this.Weapons[weaponName].WearLevel <= 0)
    //        {
    //            this.Weapons[weaponName] = null;
    //        }
    //    }
    //}

    public override string ToString()
    {
        var sb = new StringBuilder();
        var name = this.Name;
        var overallSkill = this.OverallSkill;
        return sb.ToString();
    }

    public bool CheckIfSoldierCanJoinTeam()
    {
        return true;
    }

    public void GetBonus()
    {
        
    }
}