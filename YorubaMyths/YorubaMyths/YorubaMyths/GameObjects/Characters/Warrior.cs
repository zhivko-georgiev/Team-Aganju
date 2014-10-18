namespace YorubaMyths.GameObjects.Characters
{
    using YorubaMyths.GameObjects.Characters.Player;

    public class Warrior : PlayerMele
    {
        private const int WarriorHealtPoints = 200;

        private const int WarriorDefensePoints = 50;

        private const int WarriorAttackPoints = 10;

        private const int WarriorRage = 0;

        private const double WarriorAttackSpeed = 2000;

        private const int WarriorMovementSpeed = 4;

        public Warrior(int x, int y)
            : base(WarriorMovementSpeed, WarriorHealtPoints, WarriorDefensePoints, WarriorAttackPoints, WarriorRage, WarriorAttackSpeed)
        {
            this.PositonX = x;
            this.PositionY = y;
        }
    }
}