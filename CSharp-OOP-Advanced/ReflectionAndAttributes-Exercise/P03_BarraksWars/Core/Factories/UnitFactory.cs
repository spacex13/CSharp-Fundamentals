namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;
    using Models.Units;
    public class UnitFactory : IUnitFactory
    {
        private const string unitNamespace = "_03BarracksFactory.Models.Units.";

        public IUnit CreateUnit(string unitType)
        {
            //TODO: implement for Problem 3

            Type classType = Type.GetType($"{unitNamespace}{unitType}");

            IUnit instance = (IUnit)Activator.CreateInstance(classType);

            return instance;
        }
    }
}