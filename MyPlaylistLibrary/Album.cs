using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlaylistLibrary
{
    public class Album
    {
        public string name { set; get; }
        public string artist { set; get; }

        public List<Song> songs;

        public Album(string name, string artist)
        {
            this.name = name;
            this.artist = artist;
            this.songs = new List<Song>();
        }

        public Album()
        {
            this.songs = new List<Song>();
        }
        public Song findSong(string title)
        {
            foreach (Song s in songs)
            {
                if (title.Equals(s.title))
                {
                    return s;
                }
            }
            return null;
        }

        public bool addSong(string title, double duration)
        {
            if (findSong(title) == null)
            {
                songs.Add(new Song(title, duration));
                //Console.WriteLine(title+"Successfully added to the Album");
                return true;
            }
            else
            {
                Console.WriteLine(title + "Already exists in the Album");
                return false;
            }
        }

        public bool addToPlayList(string t, List<Song> playlist)
        {
            foreach (Song s in this.songs)
            {
                if (string.Equals(t, s.title))
                {
                    playlist.Add(s);
                    Console.WriteLine(s.title + " is sussessfully added in the list");
                    return true;
                }
            }
            Console.WriteLine("There is no such song in this album");
            return false;
        }

    }
}
