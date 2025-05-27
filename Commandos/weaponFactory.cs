using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class weaponFactory 
    {
        public List<IWeapons> myWeaponse { get; } = new List<IWeapons>();

        public void addedWeapone(string name, string CodeName)
        {
            IWeapons weapons = new M16();
            myWeaponse.Add(weapons);

        }
    }
}
