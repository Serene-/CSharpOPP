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
    public class AnimalFactory : IAnimalFactory
    {
        public AnimalFactory()
        {

        }
        public IAnimal CreateAnimal(string[] input)
        {
            string type = input[0];
            IAnimal animal=null;
            if(type=="Owl")
            {
                string name = input[1];
                double weight = double.Parse(input[2]);
                double wingSize = double.Parse(input[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else if (type == "Hen")
            {
                string name = input[1];
                double weight = double.Parse(input[2]);
                double wingSize = double.Parse(input[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else if(type=="Cat")
            {
                string name = input[1];
                double weight = double.Parse(input[2]);
                string livingRegion = input[3];
                string breed = input[4];
                animal = new Cat(name, weight, livingRegion,breed);
            }
            else if (type == "Tiger")
            {
                string name = input[1];
                double weight = double.Parse(input[2]);
                string livingRegion = input[3];
                string breed = input[4];
                animal = new Tiger(name, weight, livingRegion, breed);
            }
            else if (type == "Mouse")
            {
                string name = input[1];
                double weight = double.Parse(input[2]);
                string livingRegion = input[3];
                animal = new Mouse(name, weight, livingRegion);
            }
            else if (type == "Dog")
            {
                string name = input[1];
                double weight = double.Parse(input[2]);
                string livingRegion = input[3];
                animal = new Dog(name, weight, livingRegion);
            }
            return animal;
        }
    }
}
