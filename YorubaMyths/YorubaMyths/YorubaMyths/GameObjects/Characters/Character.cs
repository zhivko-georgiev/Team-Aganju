namespace YorubaMyths.GameObjects.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using YorubaMyths.Interfaces;

    public abstract class Character : GameObject, ICharacter, IMovable
    {
        public int MovementSpeed { get; set; }
    }
}