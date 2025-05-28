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

        public FireArm(string name, string manufacturer, int numberMunitions)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.NumberMunitions = numberMunitions;
        }

    }
}
