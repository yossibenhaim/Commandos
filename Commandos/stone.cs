using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class stone : IWeapons
    {
        public int weight { get; }
        public string color { get; }
        public bool IsComplete { get; private set; } = true;
        public int HitsToBreak { get; } = 5;
        public int CurrentHits { get; private set; } = 0;

        public stone(int weight, string color)
        {
            this.weight = weight; this.color = color;
        }
        public void Shoot()
        {
            Console.WriteLine("Boom");
            this.CurrentHits--;
        }
    }
}
