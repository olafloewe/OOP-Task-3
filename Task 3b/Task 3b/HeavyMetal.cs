using System;

namespace Task_3b {
    public class HeavyMetal : Metal{
        String heavyMetalSound = "HeavyMetal";
        public HeavyMetal(String title, String author): base(title, author) {
        }

        public override String Play() {
            return $"{heavyMetalSound} {base.Play()}";
        }
    }
}