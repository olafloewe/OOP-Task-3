using System;

namespace Task_3b {
    public class Rap : HipHop {

        String rapSound = "rap";

        public Rap(String title, String author): base(title, author) {
        }

        public override String Play() {
            return $"{rapSound} {base.Play()}";
        }
    }
}