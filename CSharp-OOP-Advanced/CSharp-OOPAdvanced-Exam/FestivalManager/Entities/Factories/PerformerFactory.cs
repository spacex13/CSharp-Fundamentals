namespace FestivalManager.Entities.Factories
{
	using Contracts;
	using Entities.Contracts;
    using System;

    public class PerformerFactory : IPerformerFactory
	{
		public IPerformer CreatePerformer(string name, int age)
		{
			var performer = new Performer(name, age);

            var type = typeof(Performer);
            
            return (IPerformer)Activator.CreateInstance(type, name, age);
        }
	}
}