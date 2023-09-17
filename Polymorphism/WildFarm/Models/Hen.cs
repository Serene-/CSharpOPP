using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Hen :Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {

        }
        public override string Sound()
        {
            return "Cluck";
        }
        public override void Eats(IFood food)
        {
            FoodEaten += food.Quantity;
            this.Weight += 0.35* food.Quantity;
        }
    }
}
