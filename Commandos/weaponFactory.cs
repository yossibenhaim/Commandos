using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class weaponFactory 
    {
        public List<FireArm> myWeaponse { get; } = new List<FireArm>();

        public void addedWeapone()
        {
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    FireArm weapons = new M16();
                    myWeaponse.Add(weapons);
                    break;
                case 2:
                    FireArm weapons1 = new AK47();
                    myWeaponse.Add(weapons1);
                    break;

            }

        }
    }
}
