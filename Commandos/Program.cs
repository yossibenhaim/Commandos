using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            weaponFactory weapon = new weaponFactory();
            weapon.addedWeapone();
            Console.WriteLine(weapon.myWeaponse[0].Name);
            weapon.addedWeapone();
        }
    }
}
