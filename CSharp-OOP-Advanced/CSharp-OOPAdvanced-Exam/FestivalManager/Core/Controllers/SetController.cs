namespace FestivalManager.Core.Controllers
{
	using System.Text;
	using System.Linq;
	using Contracts;
	using Entities.Contracts;

	public class SetController : ISetController
	{
		private IStage stage;

		public SetController(IStage stage)
		{
			this.stage = stage;
		}

		public string PerformSets()
		{
			var sb = new StringBuilder();

			var setCount = 1;

			var sortedSets = this.stage.Sets
				.OrderByDescending(s => s.ActualDuration)
				.ThenByDescending(s => s.Performers.Count)
				.ToArray();

			foreach (var set in sortedSets)
			{
                var line = string.Format(OutputMessages.PrintSet, setCount++, set.Name);
				sb.AppendLine(line);

				var setWasSuccessful = set.CanPerform();

				if (!setWasSuccessful)
				{
					sb.AppendLine(OutputMessages.DidNotPerform);
					continue;
				}

				var songCount = 1;
				foreach (var song in set.Songs)
				{
                    var result = string.Format(OutputMessages.PrintSong, songCount++, song);
					sb.AppendLine(result);

					foreach (var performer in set.Performers)
					{
						foreach (var instrument in performer.Instruments)
						{
							instrument.WearDown();
						}
					}
				}

				sb.AppendLine(OutputMessages.SetSuccessful);
			}

			return sb.ToString().Trim();
		}
	}
}