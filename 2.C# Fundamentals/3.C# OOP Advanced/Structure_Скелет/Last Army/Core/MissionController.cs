using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MissionController
{
    public const int Three = 3;

    private Queue<IMission> missionQueue;
    public int SuccessMissionCounter { get; private set; }
    public int FailedMissionCounter { get; private set; }



    private IArmy army;
    private IWareHouse wareHouse;

    
    public MissionController(IArmy army, IWareHouse wareHouse)
    {
        this.army = army;
        this.wareHouse = wareHouse;
        this.missionQueue = new Queue<IMission>();
    }

    public Queue<IMission> Missions => this.missionQueue;
    private Output output=>new Output();
    public string PerformMission(IMission mission)
    {
        StringBuilder sb = new StringBuilder();
        if (this.missionQueue.Count >= Three)
        {
            sb.AppendLine(string.Format(output.MissionDeclined, this.missionQueue.Dequeue().Name));
            this.FailedMissionCounter++;
        }

        this.missionQueue.Enqueue(mission);

        int currentMissionsCount = this.missionQueue.Count;
        for (int i = 0; i < currentMissionsCount; i++)
        {
            this.wareHouse.EquipArmy(this.army);
            IMission currentMission = this.missionQueue.Dequeue();
            List<ISoldier> missionTeam = this.CollectMissionTeam(mission);

            bool successful = this.ExecuteMission(currentMission, missionTeam);

            if (successful)
            {
                sb.AppendLine(string.Format(output.MissionSuccessful, currentMission.Name));
            }
            else
            {
                this.missionQueue.Enqueue(currentMission);
                sb.AppendLine(string.Format(output.MissionOnHold, currentMission.Name));
            }
        }

        return sb.ToString();
    }

    private bool ExecuteMission(IMission mission, List<ISoldier> missionTeam)
    {
        if (missionTeam.Sum(w => w.OverallSkill) >= mission.ScoreToComplete)
        {
            foreach (ISoldier soldier in missionTeam)
            {
                soldier.CompleteMission(mission);
            }
            this.SuccessMissionCounter++;
            return true;
        }

        return false;
    }

    private List<ISoldier> CollectMissionTeam(IMission mission)
    {
        List<ISoldier> missionTeam = this.army.Soldiers.Where(s => s.ReadyForMission(mission)).ToList();
        return missionTeam;
    }

    public void FailMissionsOnHold()
    {
        while (this.missionQueue.Count > 0)
        {
            this.FailedMissionCounter++;
            this.missionQueue.Dequeue();
        }
    }
}