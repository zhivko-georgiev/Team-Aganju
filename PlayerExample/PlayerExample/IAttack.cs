using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerExample
{
    public interface IAttack
    {
        int AttackPoints { get; set; }

        int Range { get; set; }

        double AutoAttackSped { get; set; }
    }
}
