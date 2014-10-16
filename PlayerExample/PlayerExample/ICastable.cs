using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerExample
{
    public interface ICastable
    {
        int SpellRange { get; set; }

        int SpellPower { get; set; }

        int Mana { get; set; }
    }
}
