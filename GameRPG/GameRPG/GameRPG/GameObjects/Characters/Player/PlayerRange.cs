namespace GameRPG.GameObjects.Characters.Player
{
    using System;
    using GameRPG.Interfaces;

    public abstract class PlayerRange : PlayerCharacter, IRange
    {
        protected PlayerRange(int movementSpeed, int maxHealtPoints, int defensePoints, int attackPoints, int range, int rage, double autoAttackSped, int energy)
            : base(movementSpeed, maxHealtPoints, defensePoints)
        {
            this.AttackPoints = attackPoints;
            this.Range = range;
            this.Rage = rage;
            this.AutoAttackSped = autoAttackSped;
            this.Energy = energy;
        }

        public int AttackPoints { get; set; }

        public int Range { get; set; }

        public int Rage { get; set; }
        
        public double AutoAttackSped {get; set; }

        public int Energy { get; set; }
    }
}
