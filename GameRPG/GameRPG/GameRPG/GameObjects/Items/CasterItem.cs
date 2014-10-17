namespace GameRPG.GameObjects.Items
{
    using System;
    using GameRPG.Interfaces;

    public abstract class CasterItem : Item, ICastaerItem
    {
        protected CasterItem(ItemType itemType, int healtPonint, int defensePoint, int spellPower)
            : base(itemType, healtPonint, defensePoint)
        {
            this.SpellPower = spellPower;
        }

        public int SpellPower { get; set; }

        public ItemType ItemType { get; set; }
    }
}
