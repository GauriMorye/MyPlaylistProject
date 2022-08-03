using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlaylistLibrary
{
    public class Song
    {
        public string title { get; }

        public double duration { get; }

        public Song(string t, double d)
        {
            title = t;

            duration = d;
        }


        public string details()
        {
            return ($"Song[Title:{title},Duration:{duration}");
        }
    }
}
