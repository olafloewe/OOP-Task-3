using System;

namespace Task_3b {
    public class Song {

        String title;
        String artist;  

        public Song(String title, String artist) {
            this.title = title;
            this.artist = artist;
        }

        public virtual String Play() {
            return $"{title} {artist}";
        }
    }
}

