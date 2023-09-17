using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Factories.Interfaces;
using WildFarm.Models;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factories
{
    public class FoodFactory : IFoodFactory
    {
        public FoodFactory()
        {

        }
        public IFood CreateFood(string[] input)
        {
            string type = input[0];
            int quantity = int.Parse(input[1]);
            IFood food = null;
            if(type=="Meat")
            {
                food = new Meat(quantity);
            }
            else if (type == "Vegetable")
            {
                food = new Vegetable(quantity);
            }
            else if (type == "Fruit")
            {
                food = new Fruit(quantity);
            }
            else if (type == "Seeds")
            {
                food = new Seeds(quantity);
            }
            return food;
        }
    }
}
