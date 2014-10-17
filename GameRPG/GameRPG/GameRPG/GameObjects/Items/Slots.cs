namespace GameRPG.GameObjects.Items
{
    using System.Collections;
    using GameRPG.Interfaces;

    public struct Slots : ISlots
    {
        public Slots(Item head, Item shoulder, Item chest, Item weapon, Item ring, Item gloves, Item boots, Item legs, Item wrist)
            : this()
        {
            this.Head = head;
            this.Shoulder = shoulder;
            this.Chest = chest;
            this.Weapon = weapon;
            this.Ring = ring;
            this.Gloves = gloves;
            this.Boots = boots;
            this.Legs = legs;
            this.Wrist = wrist;
        }

        public Item Head { get; set; }

        public Item Shoulder { get; set; }

        public Item Chest { get; set; }

        public Item Weapon { get; set; }

        public Item Ring { get; set; }

        public Item Gloves { get; set; }


        public Item Boots { get; set; }

        public Item Legs { get; set; }

        public Item Wrist { get; set; }
    }
}
