namespace GameRPG.GameObjects.Items
{
    using System;
    using GameRPG.GameObjects.Characters;
    using GameRPG.Interfaces;

    public abstract class Item : GameObject, IItem, IEquatable<Item>
    {
        protected Item(ItemType itemType, int healtPonint, int defensePoint)
        {
            this.HealtPonint = healtPonint;
            this.DefensePoint = defensePoint;
            this.ItemType = itemType;
        }

        public int HealtPonint { get; set; }

        public int DefensePoint { get; set; }

        public ItemType ItemType { get; set; }

        public override string ToString()
        {
            return string.Format("Item Type {0} :", this.ItemType);
        }

        public bool Equals(Item other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.HealtPonint == other.HealtPonint && this.DefensePoint == other.DefensePoint
                   && this.ItemType == other.ItemType;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((Item)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = this.HealtPonint;
                hashCode = (hashCode * 397) ^ this.DefensePoint;
                hashCode = (hashCode * 397) ^ (int)this.ItemType;
                return hashCode;
            }
        }

        public static bool operator ==(Item left, Item right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Item left, Item right)
        {
            return !Equals(left, right);
        }
    }
}