using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameRPG.GameObjects.Characters
{
    using GameRPG.Interfaces;

    public abstract class Character : GameObject, ICharacter, IMovable
    {
        public int PositonX { get; set; }

        public int PositionY { get; set; }

        public int MovementSpeed { get; set; }
    }
}
