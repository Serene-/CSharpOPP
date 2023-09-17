using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public abstract class Bird : Animal
    {
        public Bird(string name, double weight, double wingSize) : base(name, weight)
        {
            WingSize = wingSize;
        }
        public  double WingSize { get; }
        public override string ToString()
        {
            return String.Format($"{this.GetType().Name} [{Name}, {WingSize}, {Weight:F1}, {FoodEaten}]");
        }


    }
}
