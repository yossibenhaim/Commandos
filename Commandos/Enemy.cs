using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Enemy
    {
        public string name;
        public int life { get; private set; } = 100;
        public bool IsLife { get; private set; } = true;

        public string rank { get; private set; }

        public Enemy(string name, string rank)
        { this.name = name; this.rank = rank; }

        public void DeclineLife()
        { this.life-= 10; this.CheckIfLife(); }
        public void CheckIfLife()
        { if (this.life <= 0)
            { this.IsLife = false; }
        }
        public void Shout()
        { Console.WriteLine("I am enemy!!!"); }
    }
}
