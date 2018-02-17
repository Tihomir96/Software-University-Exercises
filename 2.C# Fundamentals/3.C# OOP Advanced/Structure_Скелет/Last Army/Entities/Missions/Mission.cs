using System.Collections;
using System.Collections.Generic;

public abstract class Mission : IMission
{
    protected Mission(double enduranceReq,double scoreToComplete)
    {
        this.EnduranceRequired = enduranceReq;
        this.ScoreToComplete = scoreToComplete;
     
    }

    public string Name  { get; protected set; }

    public double EnduranceRequired { get; set; }
    public double ScoreToComplete { get;  }
    public double WearLevelDecrement { get; }
    public IEnumerable<object> MissionWeapons { get;  }
}

