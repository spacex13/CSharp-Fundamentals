using System;
using System.Linq;

namespace FestivalManager.Core
{
	using System.Reflection;
	using Contracts;
	using Controllers;
	using Controllers.Contracts;
    using FestivalManager.Core.IO;
    using FestivalManager.Entities;
    using FestivalManager.Entities.Contracts;
    using IO.Contracts;

	public class Engine : IEngine
	{
        public Engine(IFestivalController fc, ISetController sc)
        {
            this.reader = new ConsoleReader();
            this.writer = new ConsoleWriter();

            this.stage = new Stage();
            this.festivalCоntroller = fc;
            this.setCоntroller = sc;
        }

	    private IReader reader;
	    private IWriter writer;

        private IStage stage;
		private IFestivalController festivalCоntroller;
		private ISetController setCоntroller;

		public void Run()
		{
			while (true) 
			{
				var input = reader.ReadLine();

				if (input == "END")
					break;

				try
				{
					string.Intern(input);

					var result = this.ProcessCommand(input);
					this.writer.WriteLine(result);
				}
				catch (Exception ex)
				{
                    var line = string.Format(OutputMessages.Error, ex.Message);
					this.writer.WriteLine(line);
				}
			}

			var end = this.festivalCоntroller.ProduceReport();

			this.writer.WriteLine(OutputMessages.Results);
			this.writer.WriteLine(end);
		}

		public string ProcessCommand(string input)
		{
			var info = input.Split(" ".ToCharArray().First());

			var command = info.First();
			var commandArgs = info.Skip(1).ToArray();

			if (command == "LetsRock")
			{
				var sets = this.setCоntroller.PerformSets();
				return sets;
			}

            var executeCommand = this.festivalCоntroller.GetType()
				.GetMethods()
				.FirstOrDefault(x => x.Name == command);

			string result;

			try
			{
                result = (string)executeCommand.Invoke(this.festivalCоntroller, new object[] { commandArgs });
			}
			catch (Exception ex)
			{
                throw new Exception(ex.InnerException.Message);
			}

			return result;
		}
	}
}