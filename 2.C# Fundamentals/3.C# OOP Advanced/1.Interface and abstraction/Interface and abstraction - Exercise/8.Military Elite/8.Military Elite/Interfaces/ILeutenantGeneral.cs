using System.Collections.Generic;

namespace _8.Military_Elite
{
    public interface ILeutenantGeneral : IPrivate
    {
        IList<ISoldier> Soldiers { get; }
    }
}
