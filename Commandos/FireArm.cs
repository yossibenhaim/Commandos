using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal abstract class FireArm
    {
        public string Name { get; }
        public string Manufacturer { get; }
        public int NumberMunitions { get; protected set; }

        public FireArm(string Nmae, string Manufacturer, int NumberMunitions)
        {
            this.Name = Name;
            this.Manufacturer = Manufacturer;
            this.NumberMunitions = NumberMunitions;
        }

    }
}
