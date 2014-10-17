namespace GameRPG.GameObjects.Characters.Player
{
    using System;
    using GameRPG.Interfaces;

    public abstract class PlayerMele : PlayerCharacter, IMele
    {

        private const int MeleRange = 2;

        public PlayerMele(int movementSpeed, int maxHealtPoints, int defensePoints, int attackPoints, int rage, double autoAttackSped)
            : base(movementSpeed, maxHealtPoints, defensePoints)
        {
            this.AttackPoints = attackPoints;
            this.Range = MeleRange;
            this.Rage = rage;
            this.AutoAttackSped = autoAttackSped;
        }

        public int AttackPoints { get; set; }

        public int Range { get; set; }

        public int Rage { get; set; }

        public double AutoAttackSped { get; set; }
    }
}
