﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Raiding.Models
{
    public class Paladin :BaseHero
    {
        private const int power = 100;
        public Paladin(string name) : base(name, power)
        {
        }
        public override string CastAbility()
        {
            return String.Format($"{this.GetType().Name} - {this.Name} healed for {power}");
        }
    }
}
