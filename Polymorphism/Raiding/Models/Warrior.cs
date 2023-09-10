﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Warrior :BaseHero
    {
        private const int power = 100;
        public Warrior(string name) : base(name, power)
        {
        }
        public override string CastAbility()
        {
            return String.Format($"{this.GetType().Name} - {this.Name} hit for {power} damage");
        }
    }
}
