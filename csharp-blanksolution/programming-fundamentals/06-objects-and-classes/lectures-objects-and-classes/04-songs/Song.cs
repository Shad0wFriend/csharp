using System;
using System.Collections.Generic;
using System.Text;

namespace _04_songs
{
    class Song
    {
        public string Playlist { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }

        public Song(string v1, string v2, string v3)
        {
            this.Playlist = v1;
            this.Name = v2;
            this.Time = v3;
        }
    }
}

