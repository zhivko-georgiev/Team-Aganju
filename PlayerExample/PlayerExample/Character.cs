using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerExample
{
    public abstract class Character : GameObject, ICharacter, IMovable
    {
        public int PositonX { get; set; }

        public int PositionY { get; set; }

        public int MovementSpeed { get; set; }
    }
}
