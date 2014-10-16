using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerExample
{
    public interface ISlots
    {
        Item Head { get; set; }

        Item Shoulder { get; set; }

        Item Chest { get; set; }

        Item Weapon { get; set; }

        Item Ring { get; set; }

        Item Gloves { get; set; }

        Item Boots { get; set; }

        Item Legs { get; set; }

        Item Wrist { get; set; }

    }
}
