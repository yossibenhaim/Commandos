using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class EnemyFactory
    {
        public List<Enemy> myEnemy = new List<Enemy>();

        public void addedCommando(string name, string rank)
        {
            Enemy enemy = new Enemy(name, rank);
            myEnemy.Add(enemy);

        }
    }
}
