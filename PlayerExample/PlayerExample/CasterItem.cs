using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerExample
{
    public abstract class CasterItem : Item, ICastaerItem
    {
        protected CasterItem(ItemType itemType, int healtPonint, int defensePoint, int spellPower)
            : base(itemType, healtPonint, defensePoint)
        {
            this.SpellPower = spellPower;
        }

        public int SpellPower { get; set; }
    }
}
