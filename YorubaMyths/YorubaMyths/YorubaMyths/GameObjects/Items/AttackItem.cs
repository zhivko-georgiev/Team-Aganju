namespace YorubaMyths.GameObjects.Items
{
    using System;
    using YorubaMyths.Interfaces;

    public abstract class AttackItem : Item, IAttackItem
    {
        protected AttackItem(ItemType itemType, int healtPonints, int defensePoints, int attackPoints)
            : base(itemType, healtPonints, defensePoints)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints { get; set; }
    }
}