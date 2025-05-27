using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class weaponFactory
    {
        public List<IWeapons> myWeapone = new List<IWeapons>();

        public void addedWeapone(string name, string CodeName)
        {
            IWeapons weapons = new IWeapons();
            myWeapone.Add(weapons);

        }

        public IWeapons manu(string name)
        {

        }

    }
}
