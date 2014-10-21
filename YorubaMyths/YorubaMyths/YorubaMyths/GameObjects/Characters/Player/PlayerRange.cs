namespace YorubaMyths.GameObjects.Characters.Player
{
    using System;
    using YorubaMyths.Interfaces;

    public abstract class PlayerRange : PlayerCharacter, IRange
    {
        protected PlayerRange(int currentHealthPoints, int movementSpeed, int maxHealthPoints, int defensePoints, int attackPoints, int range, int rage, double autoAttackSpeed, int energy)
            : base(currentHealthPoints, movementSpeed, maxHealthPoints, defensePoints, attackPoints)
        {
            this.Range = range;
            this.Rage = rage;
            this.AutoAttackSpeed = autoAttackSpeed;
            this.Energy = energy;
        }

        public int Range { get; set; }

        public int Rage { get; set; }

        public double AutoAttackSpeed { get; set; }

        public int Energy { get; set; }
    }
}