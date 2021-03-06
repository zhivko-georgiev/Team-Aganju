﻿namespace GameRPG.Interfaces
{
    using GameRPG.GameObjects.Items;

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
