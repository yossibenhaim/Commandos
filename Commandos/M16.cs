using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class M16 : FireArm, IWeapons 
    {
        public M16() : base("M16", "Colt", 29) { }
        public void Shoot()
        {
            Console.WriteLine("Boom");
            this.NumberMunitions--;
        }
    }
}
