namespace PlayerExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class PlayerCharacter : Character, IPlayer
    {
        private IList<Item> playerInventory;

        private Item[] equipedItems;

        private SLots playerSlots;

        protected PlayerCharacter(int movementSpeed, int maxHealtPoints, int defensePoints)
        {
            this.MovementSpeed = movementSpeed;
            this.MaxHealtPoints = maxHealtPoints;
            this.DefensePoints = defensePoints;
            this.IsAlive = true;
            this.playerSlots = new SLots();
            this.equipedItems = new Item[9];
            this.playerInventory = new List<Item>();
        }

        public int MaxHealtPoints { get; set; }

        public int DefensePoints { get; set; }

        public int CurrentHealtPoints { get; set; }

        public bool IsAlive { get; set; }

        public void AddToInvertory(Item item)
        {
            this.playerInventory.Add(item);
        }

        public virtual void EquipedItem(Item item)
        {
            if (this.playerInventory.Contains(item) && item != null)
            {
                this.ItemEquip(item);

                this.playerInventory.Remove(item);
                this.AddItemEffect();
            }
        }

        public virtual void UnEquipItem(Item item)
        {
            if (this.equipedItems.Contains(item))
            {
                this.ItemUnequip(item);
                this.playerInventory.Add(item);
                this.RemoveItemEffect(item);
            }
        }

        private void ItemEquip(Item item)
        {
            switch (item.ItemType)
            {
                case ItemType.Head:
                    this.playerSlots.Head = item;
                    this.equipedItems[0] = this.playerSlots.Head;
                    break;
                case ItemType.Shoulder:
                    this.playerSlots.Shoulder = item;
                    this.equipedItems[1] = this.playerSlots.Shoulder;
                    break;
                case ItemType.Chest:
                    this.playerSlots.Chest = item;
                    this.equipedItems[2] = this.playerSlots.Chest;
                    break;
                case ItemType.Wrist:
                    this.playerSlots.Wrist = item;
                    this.equipedItems[3] = this.playerSlots.Wrist;
                    break;
                case ItemType.Gloves:
                    this.playerSlots.Gloves = item;
                    this.equipedItems[4] = this.playerSlots.Gloves;
                    break;
                case ItemType.Legs:
                    this.playerSlots.Legs = item;
                    this.equipedItems[5] = this.playerSlots.Legs;
                    break;
                case ItemType.Boots:
                    this.playerSlots.Boots = item;
                    this.equipedItems[6] = this.playerSlots.Boots;
                    break;
                case ItemType.Ring:
                    this.playerSlots.Ring = item;
                    this.equipedItems[7] = this.playerSlots.Ring;
                    break;
                case ItemType.Weapon:
                    this.playerSlots.Weapon = item;
                    this.equipedItems[8] = this.playerSlots.Weapon;
                    break;
                default:
                    break;
            }
        }

        private void ItemUnequip(Item item)
        {
            for (int i = 0; i < this.equipedItems.Length; i++)
            {
                if (this.equipedItems[i] != null)
                {
                    if (this.equipedItems[i].ItemType == item.ItemType)
                    {
                        this.equipedItems[i] = null;
                    }
                }
            }
        }

        private void RemoveItemEffect(Item item)
        {
            this.DefensePoints -= item.DefensePoint;
            this.MaxHealtPoints -= item.HealtPonint;
        }

        private void AddItemEffect()
        {
            foreach (Item item in this.equipedItems)
            {
                if (item != null)
                {
                    this.DefensePoints += item.DefensePoint;
                    this.MaxHealtPoints += item.HealtPonint;
                }
            }
        }
    }
}