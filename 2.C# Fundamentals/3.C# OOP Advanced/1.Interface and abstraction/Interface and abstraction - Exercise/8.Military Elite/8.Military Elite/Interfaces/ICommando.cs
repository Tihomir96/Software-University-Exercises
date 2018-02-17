
using System.Collections.Generic;

namespace _8.Military_Elite.Interfaces
{
    interface ICommando:ISpecialisedSoldier
    {
        IList<IMission> Missions { get; }
        void CompleteMission();
    }
}
