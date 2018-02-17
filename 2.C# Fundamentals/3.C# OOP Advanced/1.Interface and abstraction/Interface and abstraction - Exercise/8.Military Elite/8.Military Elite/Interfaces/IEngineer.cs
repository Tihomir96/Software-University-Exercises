using System.Collections.Generic;

namespace _8.Military_Elite.Interfaces
{
    public interface IEngineer:ISpecialisedSoldier
    {
        IList<IRepair> Parts { get; }
    }
}
