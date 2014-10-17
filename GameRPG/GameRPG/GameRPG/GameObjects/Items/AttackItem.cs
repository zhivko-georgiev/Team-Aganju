﻿namespace GameRPG.GameObjects.Items
{
    using System;
    using GameRPG.Interfaces;

    public abstract class AttackItem : Item, IAttackItem
    {
        protected AttackItem(ItemType itemType, int healtPonint, int defensePoint, int attackPoint)
            : base(itemType, healtPonint, defensePoint)
        {
            this.AttackPoint = attackPoint;
        }

        public int AttackPoint { get; set; }
    }
}
