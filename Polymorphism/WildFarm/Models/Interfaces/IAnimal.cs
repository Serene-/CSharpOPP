using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models.Interfaces
{
    public interface IAnimal
    {
        string Name { get; }
        double Weight { get; set; }
        int FoodEaten { get; set; }
        void Eats(IFood food);
        string Sound();
    }
}
