using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Commando
    {
        public string Name { get; }
        public string CodeName { get; }

        public Object Tool { get; }
        public int CountLife { get; private set; } = 100;
        public string status { get; private set; } = "Walk";

        public Commando(string Name, string CodeName, object tool)
        {
            this.Name = Name;
            this.CodeName = CodeName;
            Tool = tool;
        }
        
        public void walk()
        {
            Console.WriteLine("The soldier is leaving.");
            this.status = "walk";
        }

        public void Hiding()
        {
            Console.WriteLine("The soldier is hiding.");
            this.status = "Hiding";
        }

        public void attacks()
        {
            Console.WriteLine("The soldier attacks.");
            this.status = "attacks";
        }
    }
}
