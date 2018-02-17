using System;
using System.Collections.Generic;
using System.Text;

public class GameController
{
    private Dictionary<string, List<ISoldier>> army;
    private Dictionary<string, List<IAmmunition>> wearHouse;
   private MissionController missionControllerField;
    private AmmunitionFactory ammoFactory;
    private IArmy armyClass;
    private IWareHouse wareHouse;
    private ISoldierFactory soldiersFactory;
    private SoldierController soldierController;
    private MissionFactory missionFactory;
    private Output output;

    public GameController()
    {
        this.army = new Dictionary<string, List<ISoldier>>();
        this.wearHouse = new Dictionary<string, List<IAmmunition>>();
        this.armyClass=new Army();
        this.wareHouse=new WareHouse();
        this.missionControllerField = new MissionController(armyClass,wareHouse);
        this.ammoFactory= new AmmunitionFactory();     
      this.soldiersFactory=new SoldierFactory();
        this.soldierController=new SoldierController();
        this.missionFactory=new MissionFactory();
        
        
    }

    public Dictionary<string, List<ISoldier>> Army
    {
        get { return this.army; }
        set { army = value; }
    }



    public Dictionary<string, List<IAmmunition>> WearHouse
    {
        get { return wearHouse; }
        set { wearHouse = value; }
    }

    public MissionController MissionControllerField
    {
        get { return missionControllerField; }
        set { missionControllerField = value; }
    }

    public void GiveInputToGameController(string input)
    {
        var data = input.Split();

        if (data[0].Equals("Soldier"))
        {
            string type = string.Empty;
            string name = string.Empty;
            int age = 0;
            int experience = 0;
            double speed = 0d;
            double endurance = 0d;
            double motivation = 0;
            double maxWeight = 0d;

            if (data.Length == 3)
            {
                type = data[1];
                name = data[2];
            }
            else
            {
                type = data[1];
                name = data[2];
                age = int.Parse(data[3]);
                experience = int.Parse(data[4]);
                speed = double.Parse(data[5]);
                endurance = double.Parse(data[6]);
                motivation = double.Parse(data[7]);
                maxWeight = double.Parse(data[8]);
            }
            ISoldier soldier = null;
            switch (type)
            {
                case "Ranker":
                   soldier= soldiersFactory.CreateSoldier(type, name, age, experience, endurance);
                    
                    AddSoldierToArmy(soldier, type);
                    break;
                case "Corporal":
                    soldier = soldiersFactory.CreateSoldier(type, name, age, experience, endurance);

                    AddSoldierToArmy(soldier, type);
                    break;
                case "Special-Force":
                    soldier = soldiersFactory.CreateSoldier(type, name, age, experience, endurance);

                    AddSoldierToArmy(soldier, type);
                    break;
                case "Regenerate":
                    this.soldierController.TeamRegenerate(army, name);
                    break;
                case "Vacation":
                    this.soldierController.TeamGoesOnVacation(army, name);
                    break;
                case "Bonus":
                    this.soldierController.TeamGetBonus(army, name);
                    break;
            }

        }
        else if (data[0].Equals("WearHouse"))
        {
            string name = data[1];
            int number = int.Parse(data[2]);

            AddAmmunitions(ammoFactory.CreateAmmunition(name, number));
        }
        else if (data[0].Equals("Mission"))
        {
            var mission = this.missionFactory.CreateMission(data[1], double.Parse(data[2]));   
            this.missionControllerField.PerformMission(mission);
        }
    }

    public string RequestResult(StringBuilder result)
    {

        return output.GiveOutput(result, army, wearHouse, this.missionControllerField.Missions.Count);
        
    }

    private void AddAmmunitions(IAmmunition ammunition)
    {
        if (!this.wearHouse.ContainsKey(ammunition.Name))
        {
            this.wearHouse[ammunition.Name] = new List<IAmmunition>();
            this.wearHouse[ammunition.Name].Add(ammunition);
        }
        else
        {
            this.wearHouse[ammunition.Name][0].Number += ammunition.Number;
        }
    }

    private void AddSoldierToArmy(ISoldier soldier, string type)
    {
        var debug = 1;
        if (debug == 1)
        {
            throw new ArgumentException($"The soldier {soldier.Name} is not skillful enough {type} team");
        }

        if (!this.army.ContainsKey(type))
        {
            this.army[type] = new List<ISoldier>();
        }
        this.army[type].Add(soldier);
    }
}
