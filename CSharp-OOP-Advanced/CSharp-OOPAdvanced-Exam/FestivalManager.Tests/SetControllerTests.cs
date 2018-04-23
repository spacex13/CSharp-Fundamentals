// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to your project (entities/controllers/etc)
namespace FestivalManager.Tests
{
    using FestivalManager.Core.Controllers;
    using FestivalManager.Entities;
    using FestivalManager.Entities.Instruments;
    using FestivalManager.Entities.Sets;
    using NUnit.Framework;

    [TestFixture]
	public class SetControllerTests
    {
		[Test]
	    public void SetDidNotPerform()
	    {
            Stage stage = new Stage();
            SetController sc = new SetController(stage);
            var set = new Short("mySet");
            stage.AddSet(set);

            var result = sc.PerformSets();
            Assert.IsTrue(result.Contains("-- Did not perform"));
        }

        [Test]
        public void SetWasPerformed()
        {
            Stage stage = new Stage();
            SetController sc = new SetController(stage);
            var set = new Short("mySet");
            Performer p = new Performer("PP", 19);
            set.AddPerformer(p);
            Song s = new Song("song", new System.TimeSpan(0, 3, 0));
            set.AddPerformer(p);
            p.AddInstrument(new Guitar());
            set.AddSong(s);

            stage.AddSet(set);
            var result = sc.PerformSets();

            Assert.IsTrue(result.Contains("1. mySet:"));
        }

        //[Test]
        //public void SetWasPerformed()
        //{
        //    Stage stage = new Stage();
        //    SetController sc = new SetController(stage);
        //    var set = new Short("mySet");
        //    Performer p = new Performer("PP", 19);
        //    set.AddPerformer(p);
        //    Song s = new Song("song", new System.TimeSpan(0, 3, 0));
        //    set.AddPerformer(p);
        //    p.AddInstrument(new Guitar());
        //    set.AddSong(s);

        //    stage.AddSet(set);
        //    var result = sc.PerformSets();

        //    Assert.IsTrue(result.EndsWith("-- Set Successful"));
        //}

        [Test]
        public void SongIsPlayed()
        {
            Stage stage = new Stage();
            SetController sc = new SetController(stage);
            var set = new Short("mySet");
            Performer p = new Performer("PP", 19);
            Song s = new Song("song", new System.TimeSpan(0, 3, 0));

            p.AddInstrument(new Guitar());
            stage.AddPerformer(p);
            set.AddPerformer(p);
            set.AddSong(s);
            stage.AddSet(set);

            var result = sc.PerformSets();
            Assert.IsTrue(result.Contains("-- 1. song"));
        }

        [Test]
        public void WornDown()
        {
            Stage stage = new Stage();
            SetController sc = new SetController(stage);

            var set = new Short("mySet");
            Performer p = new Performer("PP", 19);
            var g = new Guitar();
            p.AddInstrument(g);
            Song s = new Song("song", new System.TimeSpan(0, 3, 0));
            set.AddPerformer(p);
            set.AddSong(s);

            stage.AddSet(set);
            sc.PerformSets();            

            Assert.That(g.Wear < 100);
        }
    }
}
