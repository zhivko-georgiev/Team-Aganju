namespace YorubaMyths.GameObjects.Characters.Player
{
    using System;
    using YorubaMyths.Interfaces;

    public abstract class PlayerCast : PlayerCharacter, ICastable
    {
        protected PlayerCast(int movementSpeed, int maxHealtPoints, int defensePoints, int attackPoints, int spellRange, int spellPower, int mana)
            : base(movementSpeed, maxHealtPoints, defensePoints, attackPoints)
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