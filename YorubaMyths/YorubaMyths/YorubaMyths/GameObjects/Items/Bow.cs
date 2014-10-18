using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YorubaMyths.GameObjects.Items
{
    public class Bow : AttackItem
    {
        private const int BowAttack = 15;

        private const int BowDefense = 5;

        private const int HealtPoints = 10;

        public Bow()
            : base(ItemType.Weapon, HealtPoints, BowAttack, BowDefense)
        {
        }
    }
}