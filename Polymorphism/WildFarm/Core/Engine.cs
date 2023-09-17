using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Core.Interfaces;
using WildFarm.Factories;
using WildFarm.Factories.Interfaces;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private List<IAnimal> animals;
        private readonly IAnimalFactory animalFactory;
        private readonly IFoodFactory foodFactory;
        public Engine()
        { 
        }
        public Engine(IReader reader,IWriter writer,IAnimalFactory animalFactory,IFoodFactory foodFactory):this()
        {
            this.reader = reader;
            this.writer = writer;
            animals = new List<IAnimal>();
            this.animalFactory = animalFactory;
            this.foodFactory = foodFactory;
        }

        public void Run()
        {
            string command = reader.ReadLine();
            bool even=true;
            while(command!="End")
            {
                string[] input = command.Split(' ');
                if (even)
                {
                    if(animalFactory.CreateAnimal(input)!=null) animals.Add(animalFactory.CreateAnimal(input));
                    even = false;
                }
                else
                {
                    if(foodFactory.CreateFood(input)!=null)
                    {
                        IAnimal animal = animals.LastOrDefault();
                        IFood food = foodFactory.CreateFood(input);
                        try
                        {
                            animal.Eats(food);
                            writer.WriteLine(animal.Sound());
                        }
                        catch(ArgumentException ex)
                        {
                            writer.WriteLine(ex.Message);
                        }
                       
                    }
                    even = true;
                }
                
                command = reader.ReadLine();
            }
            Print();
        }
        public void Print()
        {
            foreach(var animal in animals)
            {
                writer.WriteLine(animal.ToString());
            }
        }
    }
}
