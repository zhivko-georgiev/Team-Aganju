using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerExample
{
    class TestProgram
    {
        private static void Main()
        {
            AttackItem sword = new Sword();

            PlayerMele gosho = new Warrior(10, 10);
            Console.WriteLine(gosho.DefensePoints);
            gosho.AddToInvertory(sword);
            gosho.EquipedItem(sword);
            gosho.UnEquipItem(sword);
            Console.WriteLine(gosho.DefensePoints);
           
           
        }
    }
}
