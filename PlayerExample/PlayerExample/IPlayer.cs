using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerExample
{
    public interface IPlayer
    {

        int MaxHealtPoints { get; set; }

        int DefensePoints { get; set; }

        int CurrentHealtPoints { get; set; }

        bool IsAlive { get; set; }
    }
}
