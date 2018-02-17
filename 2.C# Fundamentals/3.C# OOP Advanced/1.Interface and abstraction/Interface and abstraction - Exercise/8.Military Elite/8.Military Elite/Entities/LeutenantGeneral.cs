using System;
using System.Collections.Generic;
using System.Text;

namespace _8.Military_Elite.Entities
{
    public class LeutenantGeneral:Private,ILeutenantGeneral
    {
        public LeutenantGeneral(string id, string firstName, string lastName, double salary,IList<ISoldier> soldiers) : base(id, firstName, lastName, salary)
        {
            this.Soldiers = soldiers;
        }

        public IList<ISoldier> Soldiers { get; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Privates:");
            sb.AppendLine($"  {string.Join(Environment.NewLine+"  ", this.Soldiers)}");
            return sb.ToString().Trim();
        }
    }
}
