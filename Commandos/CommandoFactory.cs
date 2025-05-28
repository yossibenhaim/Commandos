using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class CommandoFactory 
    {
        List<Commando> myCommando = new List<Commando>();

        public void addedCommando(string name, string CodeName, IWeapons Tool)
        {
            Commando commando = new Commando(name, CodeName, Tool);
            myCommando.Add(commando);

        }
    }
}
