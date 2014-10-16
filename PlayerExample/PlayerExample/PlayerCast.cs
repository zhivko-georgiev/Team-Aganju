using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerExample
{
    public abstract class PlayerCast : PlayerCharacter, ICastable
    {
        protected PlayerCast(int movementSpeed, int maxHealtPoints, int defensePoints, int spellRange, int spellPower, int mana)
            : base(movementSpeed, maxHealtPoints, defensePoints)
        {
            this.SpellRange = spellRange;
            this.SpellPower = spellPower;
            this.Mana = mana;
        }

        public int SpellRange { get; set; }

        public int SpellPower { get; set; }


        public int Mana { get; set; }
    }
}
