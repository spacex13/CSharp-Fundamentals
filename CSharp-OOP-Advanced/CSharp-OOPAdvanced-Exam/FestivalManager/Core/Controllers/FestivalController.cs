namespace FestivalManager.Core.Controllers
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;
    using Entities.Contracts;
    using FestivalManager.Entities;
    using FestivalManager.Entities.Factories;
    using FestivalManager.Entities.Factories.Contracts;

    public class FestivalController : IFestivalController
    {
        private const string TimeFormat = "mm\\:ss";
        private const string TimeFormatLong = "{0:2D}:{1:2D}";
        private const string TimeFormatThreeDimensional = "{0:3D}:{1:3D}";

        private IStage stage = new Stage();
        private IInstrumentFactory instrumentFactory = new InstrumentFactory();
        private IPerformerFactory performerFactory = new PerformerFactory();

        public FestivalController(IStage stage)
        {
            this.stage = stage;
        }

        public string ProduceReport()
        {
            var result = string.Empty;
            var totalFestivalLength = new TimeSpan(this.stage.Sets.Sum(s => s.ActualDuration.Ticks));

            int mins = (int)totalFestivalLength.TotalMinutes;
            int secs = (int)totalFestivalLength.TotalSeconds - mins * 60;

            string t = string.Format("{0:D2}:{1:D2}", mins, secs);
            result += (string.Format(OutputMessages.FestivalLength, t));

            foreach (var set in this.stage.Sets)
            {
                var setTime = set.ActualDuration;
                mins = (int)setTime.TotalMinutes;
                secs = (int)setTime.TotalSeconds - mins * 60;

                t = string.Format("{0:D2}:{1:D2}", mins, secs);
                result += (string.Format(OutputMessages.Set, set.Name, t));

                var performersOrderedDescendingByAge = set.Performers.OrderByDescending(p => p.Age);
                foreach (var performer in performersOrderedDescendingByAge)
                {
                    var instruments = string.Join(", ", performer.Instruments
                        .OrderByDescending(i => i.Wear));

                    result += (string.Format(OutputMessages.PrintPerformer, performer.Name, instruments));
                }

                if (!set.Songs.Any())
                    result += (OutputMessages.NoSongsPlayed);
                else
                {
                    result += (OutputMessages.SongsPlayed);
                    foreach (var song in set.Songs)
                    {
                        result += (string.Format(OutputMessages.PrintSongs, song.Name, song.Duration.ToString(TimeFormat)));
                    }
                }
            }

            return result.ToString().Trim();
        }

        public string RegisterSet(string[] args)
        {
            var name = args[0];
            var typeName = args[1];

            var type = Assembly.GetCallingAssembly().GetTypes().Single(t => t.Name == typeName);
            var set = (ISet)Activator.CreateInstance(type, name);

            stage.AddSet(set);
            var result = string.Format(OutputMessages.RegisteredSet, typeName);

            return result.Trim();
        }

        public string SignUpPerformer(string[] args)
        {
            var name = args[0];
            var age = int.Parse(args[1]);

            var instrumentsInfo = args.Skip(2).ToArray();

            var instruments = instrumentsInfo
                .Select(i => this.instrumentFactory.CreateInstrument(i))
                .ToArray();

            var performer = this.performerFactory.CreatePerformer(name, age);

            foreach (var instrument in instruments)
            {
                performer.AddInstrument(instrument);
            }

            this.stage.AddPerformer(performer);

            var result = string.Format(OutputMessages.SignedUpPerformer, performer.Name);

            return result.Trim();
        }

        public string RegisterSong(string[] args)
        {
            var name = args[0];
            var timeSpan = TimeSpan.Parse("00:" + args[1]);

            var song = new Song(name, timeSpan);

            var result = string.Format(OutputMessages.RegisteredSong, song);
            this.stage.AddSong(song);
            return result.Trim();
        }

        public string AddSongToSet(string[] args)
        {
            var songName = args[0];
            var setName = args[1];

            if (!this.stage.HasSet(setName))
            {
                throw new InvalidOperationException(OutputMessages.InvalidSet);
            }

            if (!this.stage.HasSong(songName))
            {
                throw new InvalidOperationException(OutputMessages.InvalidSong);
            }

            var set = this.stage.GetSet(setName);
            var song = this.stage.GetSong(songName);

            set.AddSong(song);

            var result = string.Format(OutputMessages.SongAddedToSet, song, set.Name);
            return result.Trim();
        }

        public string AddPerformerToSet(string[] args)
        {
            var performerName = args[0];
            var setName = args[1];

            if (!this.stage.HasPerformer(performerName))
            {
                throw new InvalidOperationException(OutputMessages.InvalidPerformer);
            }

            if (!this.stage.HasSet(setName))
            {
                throw new InvalidOperationException(OutputMessages.InvalidSet);
            }

            var performer = this.stage.GetPerformer(performerName);
            var set = this.stage.GetSet(setName);

            set.AddPerformer(performer);

            var result = string.Format(OutputMessages.PerformerAddedToSet, performerName, setName);
            return result.Trim();
        }

        public string RepairInstruments(string[] args)
        {
            var instrumentsToRepair = this.stage.Performers
                .SelectMany(p => p.Instruments)
                .Where(i => i.Wear < 100)
                .ToArray();

            foreach (var instrument in instrumentsToRepair)
            {
                instrument.Repair();
            }

            var result = string.Format(OutputMessages.RepairedInstruments, instrumentsToRepair.Length);

            return result.Trim();
        }
    }
}