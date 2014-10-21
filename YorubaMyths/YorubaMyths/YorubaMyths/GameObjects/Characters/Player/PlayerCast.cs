namespace YorubaMyths.GameObjects.Characters.Player
{
    using System;
    using YorubaMyths.Interfaces;

    public abstract class PlayerCast : PlayerCharacter, ICastable
    {
        protected PlayerCast(int currentHealthPoints, int movementSpeed, int maxHealthPoints, int defensePoints, int attackPoints, int spellRange, int spellPower, int mana)
            : base(currentHealthPoints, movementSpeed, maxHealthPoints, defensePoints, attackPoints)
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