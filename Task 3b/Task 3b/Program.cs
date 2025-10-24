using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3b {
    internal class Program {
        static void Main(string[] args) {

            Player music = new Player();

            bool exit = false;

            while (!exit) { 
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine($"Current track list:\n{music.printTrackList()}");
                Console.WriteLine("1. Add Song");
                Console.WriteLine("2. Remove Song");
                Console.WriteLine("3. Play Songs");
                Console.WriteLine("4. Exit");

                ConsoleKey key = Console.ReadKey().Key;
                switch (key) {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("Enter Song Title:");
                        String title = Console.ReadLine();

                        Console.WriteLine("Enter Song Author:");
                        String author = Console.ReadLine();

                        Console.WriteLine("Select Genre:\n1. Metal\n2. Heavy Metal\n3. Death Metal\n4. Hip Hop\n5. Rap");
                        ConsoleKey genreKey = Console.ReadKey().Key;

                        Song newSong = new Song("a","a");
                        if (genreKey == ConsoleKey.D1) newSong = new Metal(title, author);
                        if (genreKey == ConsoleKey.D2) newSong = new HeavyMetal(title, author);
                        if (genreKey == ConsoleKey.D3) newSong = new DeathMetal(title, author);
                        if (genreKey == ConsoleKey.D4) newSong = new HipHop(title, author);
                        if (genreKey == ConsoleKey.D5) newSong = new Rap(title, author);

                        music.AddToTrackList(newSong);
                        
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("\nEnter Song Number to Remove:");

                        int removeIndex = int.Parse(Console.ReadLine());
                        if(removeIndex <= music.GetTrackList().Count())music.RemoveFromTrackList(removeIndex - 1);

                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine($"\n{music.printTrackList()}");
                        Console.ReadLine();

                        break;
                    case ConsoleKey.D4:
                        exit = true;
                        break;
                }
            }
        }
    }
}