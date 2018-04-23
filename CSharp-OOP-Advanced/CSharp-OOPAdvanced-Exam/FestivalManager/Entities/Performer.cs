namespace FestivalManager.Entities
{
	using System.Collections.Generic;
    using System.Text;
    using Contracts;

	public class Performer : IPerformer
	{
		private List<IInstrument> instruments;

		public Performer(string name, int age)
		{
			this.Name = name;
			this.Age = age;

			this.instruments = new List<IInstrument>();
		}

		public string Name { get; private set; }

		public int Age { get; private set; }

		public IReadOnlyCollection<IInstrument> Instruments => this.instruments;

		public void AddInstrument(IInstrument instrument)
		{
			this.instruments.Add(instrument);
		}

		public override string ToString()
		{
            StringBuilder result = new StringBuilder(this.Name + " ");

            result.Append(string.Join(", ", this.Instruments.ToString()));

			return result.ToString();
		}
	}
}
