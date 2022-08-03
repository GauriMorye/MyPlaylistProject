

using MyPlaylistLibrary;

namespace MyPlaylistProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Album> myalbums = new List<Album>();
            Album album1 = new Album("Album1", "Shreya Ghoshal");
            album1.addSong("Kaise Mujhe", 5.0);
            album1.addSong("Rozana", 3.4);
            album1.addSong("Raabta", 5.3);
            album1.addSong("Pal Pal Har Pal", 4.0);

            myalbums.Add(album1);

            Album album2 = new Album() { name = "Album2", artist = "Arjit Singh" };
            album2.addSong("Naina", 5.34);
            album2.addSong("Saawali si Raat", 2.56);
            album2.addSong("Hawaein", 3.11);
            album2.addSong("Ami Je Tomar", 4.56);

            myalbums.Add(album2);

            List<Song> playlist = new List<Song>();

            myalbums[0].addToPlayList("Kaise Mujhe", playlist);
            myalbums[1].addToPlayList("Saawali si Raat", playlist);
            myalbums[1].addToPlayList("Naina", playlist);
            myalbums[0].addToPlayList("Pal Pal Har Pal", playlist);

            Console.WriteLine("________________________");
            Play.play(playlist);

            //Sorting the playlist according to the duration
            //var sortedList = playlist.OrderBy(p => p.duration);

            //foreach (Song s in sortedList)
            //    Console.WriteLine($"{s.title} - {s.duration}");


        }





    }
}