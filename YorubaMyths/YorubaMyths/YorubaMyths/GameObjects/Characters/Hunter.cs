namespace YorubaMyths.GameObjects.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using YorubaMyths.GameObjects.Characters.Player;

    public class Hunter : PlayerRange
    {
        private const int HunterHealtPoints = 200;

        private const int HunterDefensePoints = 50;

        private const int HunterAttackPoints = 10;

        private const int HunterRage = 0;

        private const int HunterRange = 15;

        private const int HunterEnergy = 100;

        private const double HunterAttackSpeed = 2000;

        private const int HunterMovementSpeed = 2;

        public Hunter(int x, int y)
            : base(HunterMovementSpeed, HunterHealtPoints, HunterDefensePoints, HunterAttackPoints, 
            HunterRange, HunterRage, HunterAttackSpeed, HunterEnergy)
        {
            this.PositonX = x;
            this.PositionY = y;
        }
    }
}