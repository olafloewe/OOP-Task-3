using System;

namespace Task_3b {
    public class DeathMetal : Metal{
        String deathMetalSound = "Death Metal";
        public DeathMetal(String title, String author): base(title,author) {
        }

        public override String Play() {
            return $"{deathMetalSound} {base.Play()}";
        }
    }
}