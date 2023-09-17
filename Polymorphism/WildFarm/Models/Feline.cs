using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public abstract class Feline : Mammal
    { 
        public Feline(string name, double weight, string livingRegion,string breed) : base(name, weight,livingRegion)
        {
            Breed = breed;
        }
        public string Breed { get; }
        public override string ToString()
        {
            return String.Format($"{this.GetType().Name} [{Name}, {Breed}, {Weight:F1}, {LivingRegion}, {FoodEaten}]");
        }
    }
}
