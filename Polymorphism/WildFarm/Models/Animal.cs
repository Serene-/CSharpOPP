using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        public Animal(string name,double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public string Name { get; }

        public double Weight { get; set; }

        public int FoodEaten { get; set; }

        public abstract string Sound();
        public abstract void Eats(IFood food);
    }
}
