using System.Linq;
using System.Text.RegularExpressions;

public class Song
{
    private string artistName;
    private string songName;
    private string time;

    public Song(string artist, string song, string time)
    {
        ArtisName = artist;
        SongName = song;
        Time = time;
    }

    public string ArtisName
    {
        get { return artistName; }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new InvalidArtistNameException();
            }
            artistName = value;
        }
    }

    public string SongName
    {
        get { return songName; }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new InvalidSongNameException();
            }
            songName = value;
        }
    }

    public string Time
    {
        get { return time; }
        set
        {
            string pattern = @"\d+:\d+";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(value))
            {
                throw  new InvalidSongLengthException();
            }

            var timeInfo = value.Split(":").Select(int.Parse).ToArray();
            var minutes = timeInfo[0];
            var seconds = timeInfo[1];

            if (minutes < 0 || minutes > 14)
            {
                throw new InvalidSongMinutesException();
            }
            if (seconds < 0 || seconds > 59)
            {
                throw new InvalidSongSecondsException();
            }
            time = value;
        }
    }
}

