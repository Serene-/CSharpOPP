using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
           
        }
        public override string Sound()
        {
            return "Hoot Hoot";
        }
        public  override void Eats(IFood food)
        {
            string type = food.GetType().Name;
            if (type == "Meat")
            {
                FoodEaten += food.Quantity;
                this.Weight += 0.25*food.Quantity; 
            }
            else throw new ArgumentException(String.Format($"{this.GetType().Name} does not eat {type}!"));
        }
    }
}
