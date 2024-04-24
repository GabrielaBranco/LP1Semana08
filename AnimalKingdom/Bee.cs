using System;

namespace AnimalKingdom
{
    public class Bee : Animal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "BzZzZzZzz...";
        }
        public int NumberOfWings { get { return 2; } }
    }
}
