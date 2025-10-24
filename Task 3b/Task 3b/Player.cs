using System;
using System.Collections.Generic;

namespace Task_3b {

    public class Player {

        List<Song> trackList = new List<Song>();

        public Player() {

        }

        public void Play(Song song){
            Console.WriteLine(song.Play());
        }

        public void AddToTrackList(Song song){
            trackList.Add(song);
        }

        public void RemoveFromTrackList(int index) { 
            trackList.RemoveAt(index);
        }

        public List<Song> GetTrackList() {
            return trackList;
        }

        public String printTrackList() {
            String result = "";
            for (int i = 0; i < trackList.Count; i++)
            {
                result += $"{i + 1}. {trackList[i].Play()}\n";
            }
            return result;
        }
    }
}