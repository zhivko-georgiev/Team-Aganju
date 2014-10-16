using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerExample
{
    public interface IRange : IAttack
    {
        int Energy { get; set; }
    }
}
