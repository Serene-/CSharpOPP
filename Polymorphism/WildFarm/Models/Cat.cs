using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Cat:Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override string Sound()
        {
            return "Meow";
        }
        public override void Eats(IFood food)
        {
            string type = food.GetType().Name;
            if (type == "Vegetable" || type == "Meat")
            {
                FoodEaten += food.Quantity;
                this.Weight += 0.3*food.Quantity;
            }
            else throw new ArgumentException(String.Format($"{this.GetType().Name} does not eat {type}!"));
        }
    }
}
