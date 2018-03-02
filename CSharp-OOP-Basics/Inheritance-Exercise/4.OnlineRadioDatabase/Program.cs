using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.OnlineRadioDatabase
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> playlist = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                try
                {
                    string[] line = Console.ReadLine().Split(";");
                    var artistName = line[0];
                    var songName = line[1];
                    var time = line[2];
                    Song song = new Song(artistName, songName, time);
                    playlist.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine($"Songs added: {playlist.Count}");
            int result = TotalLengthOfPlaylist(playlist);
            PrintLenghtOfPlaylist(result);
        }

        private static int TotalLengthOfPlaylist(List<Song> songs)
        {
            var result = 0;
            foreach (var song in songs)
            {
                var time = song.Time.Split(":").ToArray();
                var minutes = int.Parse(time[0]);
                var seconds = int.Parse(time[1]);

                result += seconds + minutes * 60;
            }

            return result;
        }

        private static void PrintLenghtOfPlaylist(int result)
        {
            TimeSpan t = TimeSpan.FromSeconds(result);
            string playlistLength = $"{t.Hours:D1}h {t.Minutes:D1}m {t.Seconds:D1}s";
            Console.WriteLine($"Playlist length: {playlistLength}");
        }
    }
}
