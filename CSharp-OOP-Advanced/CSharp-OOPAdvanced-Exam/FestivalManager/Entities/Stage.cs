﻿namespace FestivalManager.Entities
{
	using System.Collections.Generic;
    using System.Linq;
    using Contracts;

	public class Stage : IStage
	{
        public Stage()
        {
            this.sets = new List<ISet>();
            this.songs = new List<ISong>();
            this.performers = new List<IPerformer>();
        }

		private List<ISet> sets;
		private List<ISong> songs;
        private List<IPerformer> performers;

        public IReadOnlyCollection<ISet> Sets => this.sets;

        public IReadOnlyCollection<ISong> Songs => this.songs;

        public IReadOnlyCollection<IPerformer> Performers => this.performers;

        public void AddPerformer(IPerformer performer)
        {
            this.performers.Add(performer);
        }

        public void AddSet(ISet set)
        {
            this.sets.Add(set);
        }

        public void AddSong(ISong song)
        {
            this.songs.Add(song);
        }

        public IPerformer GetPerformer(string name)
        {
            return this.performers.First(p => p.Name == name);
        }

        public ISet GetSet(string name)
        {
            return this.sets.First(p => p.Name == name);
        }

        public ISong GetSong(string name)
        {
            return this.songs.First(p => p.Name == name);
        }

        public bool HasPerformer(string name)
        {
            return this.performers.Any(p => p.Name == name);
        }

        public bool HasSet(string name)
        {
            return this.sets.Any(p => p.Name == name);
        }

        public bool HasSong(string name)
        {
            return this.songs.Any(p => p.Name == name);
        }
    }
}
