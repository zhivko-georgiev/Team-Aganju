using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YorubaMyths.Interfaces
{
    public interface IAttackItem : IItem
    {
        int AttackPoints { get; set; }
    }
}