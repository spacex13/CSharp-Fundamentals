//using _03BarracksFactory.Contracts;
//using System;
//using System.Globalization;
//using System.Linq;
//using System.Reflection;

//namespace P03_BarraksWars.Core
//{
//    public class CommandInterpreter : ICommandInterpreter
//    {
//        private const string CommandEnding = "Command";
//        private IRepository repository;
//        private IUnitFactory unitFactory;

//        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
//        {
//            this.repository = repository;
//            this.unitFactory = unitFactory;
//        }

//        public IExecutable InterpretCommand(string[] data, string commandName)
//        {
//            var commandExactName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandName) + CommandEnding;

//            var commandType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == commandExactName);

//            if (commandType == null)
//            {
//                throw new InvalidOperationException("Invalid command!");
//            }

//            IExecutable result = (IExecutable)Activator.CreateInstance(commandType, new object[] { data, this.repository, this.unitFactory});

//            return result;
//        }
//    }
//}

namespace _03BarracksFactory.Core
{
    using Contracts;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string CommandEnding = "Command";
        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            var commandCompleteName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandName) + CommandEnding;

            var commandType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == commandCompleteName);

            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid command!");
            }

            object[] commandParams =
            {
                data,
                this.repository,
                this.unitFactory
            };

            return (IExecutable)Activator.CreateInstance(commandType, commandParams);
        }
    }
}