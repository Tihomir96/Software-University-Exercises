namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        private const string unitNamespace = "_03BarracksFactory.Models.Units.";
        public IUnit CreateUnit(string unitType)
        {
            Type uniType = Type.GetType(unitNamespace+unitType);
            IUnit unitInstance = (IUnit)Activator.CreateInstance(uniType);
            return unitInstance;
        }
    }
}
