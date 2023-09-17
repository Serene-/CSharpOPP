﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, double weight,string livingRegion):base(name,weight)
        {
            LivingRegion = livingRegion;
        }

        public string LivingRegion { get; }
        public override string ToString()
        {
            return String.Format($"{this.GetType().Name} [{Name}, {Weight:F1}, {LivingRegion}, {FoodEaten}]");
        }
    }
}
