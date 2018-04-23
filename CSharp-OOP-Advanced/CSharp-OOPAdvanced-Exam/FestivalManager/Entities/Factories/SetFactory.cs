using System;
using System.Linq;
using System.Reflection;

namespace FestivalManager.Entities.Factories
{
	using Contracts;
	using Entities.Contracts;

	public class SetFactory : ISetFactory
	{
		public ISet CreateSet(string name, string typeName)
		{
            var type = Assembly.GetCallingAssembly().GetTypes().Single(t => t.Name == typeName);

            return (ISet)Activator.CreateInstance(type, name);
		}
	}
}
