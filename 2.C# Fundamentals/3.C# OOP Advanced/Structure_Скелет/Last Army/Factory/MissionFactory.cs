
    using System;
    using System.Linq;
    using System.Reflection;

public class MissionFactory:IMissionFactory
    {
        public IMission CreateMission(string difficultyLevel, double neededPoints)
        {
            Type typeMissionToCreate = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(x => x.Name.Equals(difficultyLevel, StringComparison.OrdinalIgnoreCase));

            IMission mission = (IMission)Activator.CreateInstance(typeMissionToCreate,neededPoints);
            return (IMission)mission;
    }
}

