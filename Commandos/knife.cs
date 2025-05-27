using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Commandos
{
    internal class knife : IWeapons
    {
        public string MetalType { get; }
        public string Manufacturer { get; }
        public string Color { get; }

        public int Weight { get; }

        public knife(string metalType, string manufacturer, string color, int weight)
        {
            this.Weight = weight; this.Color = color; this.Manufacturer = manufacturer; this.MetalType = metalType;
        }
        public void Shoot()
        { Console.WriteLine("Shhk"); }
    }
}
