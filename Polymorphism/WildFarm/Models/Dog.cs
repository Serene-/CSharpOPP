using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Dog :Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {

        }
        public override string Sound()
        {
            return "Woof!";
        }
        public override void Eats(IFood food)
        {
            string type = food.GetType().Name;
            if (type == "Meat")
            {
                FoodEaten += food.Quantity;
                this.Weight += 0.4*food.Quantity; 
            }
            else throw new ArgumentException(String.Format($"{this.GetType().Name} does not eat {type}!"));
        }

    }
}
