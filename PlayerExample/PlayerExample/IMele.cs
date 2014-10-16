using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerExample
{
    public interface IMele : IAttack
    {
        int Rage { get; set; }
    }
}
