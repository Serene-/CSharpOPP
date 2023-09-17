using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Mouse :Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight,livingRegion)
        {

        }
        public override string Sound()
        {
            return "Squeak";
        }
        public  override void Eats(IFood food)
        {
            string type = food.GetType().Name;
            if (type == "Vegetable" || type == "Fruit")
            {
                FoodEaten += food.Quantity;
                this.Weight += 0.1* food.Quantity; 
            }
            else throw new ArgumentException(String.Format($"{this.GetType().Name} does not eat {type}!"));
        }
    }
}
