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
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    IWeapons weapons = new M16();
                    myWeaponse.Add(weapons);
                    break;
                case 2:
                    IWeapons weapons1 = new AK47();
                    myWeaponse.Add(weapons1);
                    break;

            }

        }
    }
}
