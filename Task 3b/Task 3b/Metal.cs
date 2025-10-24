using System;

namespace Task_3b {
    public class Metal : Song {

        String metalSound = "Metal";

        public Metal(String title, String author): base(title, author) {
        }

        public override String Play() {
            return $"{metalSound} {base.Play()}";
        }
    }
}