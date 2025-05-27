﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class AK47 : FireArm, IWeapons
    {
        public AK47() : base("AK47", "KALASHNIKOV", 30) { }
        public void Shoot()
        {
            Console.WriteLine("Boom");
            this.NumberMunitions--;
        }
    }
}
