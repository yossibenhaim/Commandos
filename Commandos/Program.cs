using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando commando = new Commando();
            Console.WriteLine(commando.Name);
            Console.WriteLine(commando.NameCode);
            commando.c(5);
            Console.WriteLine(commando._CountLife);
        }
    }
}
