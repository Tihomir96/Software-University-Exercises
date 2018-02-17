using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class SoldierFactory:ISoldierFactory
    {
        
        
        public ISoldier CreateSoldier(string soldierTypeName, string name, int age, double experience, double endurance)
        {
        Type typeMissionToCreate = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(x => x.Name.Equals(soldierTypeName, StringComparison.OrdinalIgnoreCase));
            ISoldier soldier = (ISoldier)Activator.CreateInstance(typeMissionToCreate, name,age,experience,endurance);
            return (ISoldier)soldier;
    }
    }

//name, age, experience, speed, endurance, motivation, maxWeight
//public static Soldier GenerateRanker(string name, int age, int experience, double speed, double endurance,
//    double motivation, double maxWeight)
//{
//    return new Ranker(name, age, experience, speed, endurance, motivation, maxWeight);
//}

//public static Soldier GenerateCorporal(string name, int age, int experience, double speed, double endurance,
//    double motivation, double maxWeight)
//{
//    return new Corporal(name, age, experience, speed, endurance, motivation, maxWeight);
//}

//public static Soldier GenerateSpecialForce(string name, int age, int experience, double speed, double endurance,
//    double motivation, double maxWeight)
//{
//    return new SpecialForce(name, age, experience, speed, endurance, motivation, maxWeight);
//}