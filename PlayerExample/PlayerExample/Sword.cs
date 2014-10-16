using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerExample
{
    public class Sword : AttackItem
    {

        private const int SwordAttack = 20;

        private const int SwordDefense = 10;

        private const int HealtPoint = 10;

        public Sword()
            : base(ItemType.Weapon, HealtPoint, SwordDefense, SwordAttack)
        {
        }
    }
}
