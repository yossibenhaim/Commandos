using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class M16 : FireArm, IWeapons 
    {
        public M16(string Nmae, string Manufacturer, int NumberMunitions) : base(Nmae, Manufacturer, NumberMunitions) { }
        public void Shoot()
        {
            Console.WriteLine("Boom");
            this.NumberMunitions--;
        }
    }
}
