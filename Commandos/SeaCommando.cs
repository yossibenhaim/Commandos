using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class SeaCommando  : Commando
    {
        public SeaCommando(string Name, string CodeName, object tool) : base(Name, CodeName, tool) { }
    
        public void action()
        {
            Console.WriteLine("The soldier is now falling.");
        }


    }
}
