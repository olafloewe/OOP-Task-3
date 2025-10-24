using System;

namespace Task_3b {
    public class HipHop : Song{
        String hipHopSound = "HipHop";
        public HipHop(String title, String author): base(title, author) {
        }

        public override String Play() {
            return $"{hipHopSound} {base.Play()}";
        }
    }
}