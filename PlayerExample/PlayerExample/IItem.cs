using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerExample
{
    using System.Security;

    public interface IItem
    {

        ItemType ItemType { get; set; }

        int HealtPonint { get; set; }

        int DefensePoint { get; set; }
    }
}
