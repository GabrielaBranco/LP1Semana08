using System;

namespace AnimalKingdom
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Kiik Kiik...";
        }
        public int NumberOfNipples { get { return 8; } }
        public int NumberOfWings { get { return 2; } }
    }
}
