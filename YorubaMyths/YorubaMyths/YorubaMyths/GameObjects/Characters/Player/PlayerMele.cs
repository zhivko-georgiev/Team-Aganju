namespace YorubaMyths.GameObjects.Characters.Player
{
    using System;
    using YorubaMyths.Interfaces;

    public abstract class PlayerMele : PlayerCharacter, IMele
    {
        private const int MeleRange = 2;

        public PlayerMele(int currentHealthPoints, int movementSpeed, int maxHealtPoints,
            int defensePoints, int attackPoints, int rage, double autoAttackSpeed)
            : base(currentHealthPoints, movementSpeed, maxHealtPoints, defensePoints, attackPoints)
        {
            this.Range = MeleRange;
            this.Rage = rage;
            this.AutoAttackSpeed = autoAttackSpeed;
        }

        public int Range { get; set; }

        public int Rage { get; set; }

        public double AutoAttackSpeed { get; set; }
    }
}