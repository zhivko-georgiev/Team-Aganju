namespace YorubaMyths.GameObjects.Items
{
    using System;
    using YorubaMyths.Interfaces;

    public abstract class CasterItem : Item, ICastaerItem
    {
        protected CasterItem(ItemType itemType, int healtPonints, int defensePoints, int spellPower)
            : base(itemType, healtPonints, defensePoints)
        {
            this.SpellPower = spellPower;
        }

        public int SpellPower { get; set; }

        public ItemType ItemType { get; set; }
    }
}