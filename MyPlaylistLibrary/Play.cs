using MyPlaylistLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlaylistProject
{
    public class Play
    {
        public static void play(List<Song> playlist)
        {
            bool stop = false;
            int i = 0;
            if (playlist.Count == 0)
            {
                Console.WriteLine("This playlist has no songs!!");
            }
            else
            {
                Console.WriteLine("Now Playing:" + playlist[i].title);
                while (!stop)
                {
                    int option = 0;
                    printMenu();
                    //option = Convert.ToInt32(Console.ReadLine());


                    try
                    {
                        option = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.Write("Sorry there was an error in the input\n");
                    }


                    switch (option)
                    {
                        case 0:
                            Console.WriteLine("Thankyou The program has ended!!");
                            stop = true;
                            break;
                        case 1:
                            if (i == playlist.Count - 1)
                                Console.WriteLine("You have finished the playlist!!");
                            else
                                Console.WriteLine("Now Playing:" + playlist[++i].title);
                            break;
                        case 2:
                            if (i == 0)
                                Console.WriteLine("You were on the first song!!");
                            else
                                Console.WriteLine("Now Playing:" + playlist[--i].title);
                            break;
                        case 3:
                            Console.WriteLine("Now Playing:" + playlist[i].title);
                            break;
                        case 4:
                            playlist.Remove(playlist[i]);
                            break;
                        case 5:
                            printList(playlist);
                            break;
                        case 6:
                            Console.WriteLine(playlist.Sum(p => p.duration));
                            break;

                        default:
                            Console.WriteLine("Please enter a valid option");
                            break;

                    }
                }
            }
        }

        public static void printMenu()
        {
            Console.WriteLine("__________________________________");
            Console.WriteLine("MENU");
            Console.WriteLine(
                "1.To play the next song\n" +
                "2.To play the previous song\n" +
                "3.To replay the current song\n" +
                "4.Delete song from playlist\n" +
                "5.Print all songs\n" +
                "6.Total duration of playlist\n" +
                "Press 0 to exit\n");
            Console.WriteLine("__________________________________");

        }

        public static void printList(List<Song> playlist)
        {
            foreach (Song s in playlist)
                Console.WriteLine($"{s.title}");
        }
    }
}
