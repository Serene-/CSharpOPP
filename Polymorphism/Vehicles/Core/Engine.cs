using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Core.Interfaces;
using Vehicles.IO.Interfaces;
using Vehicles.Models;
using Vehicles.Models.Interfaces;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        private IRead reader;
        private IWrite writer;
        public Engine(IRead reader,IWrite writer)
        {
            this.reader = reader;
            this.writer = writer;
        }
        public void Run()
        {
            IVehicle car;
            IVehicle truck;
            string[] carInfo = reader.ReadLine().Split(' ');
            car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            string[] truckInfo = reader.ReadLine().Split(' ');
            truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));
            int repeats = int.Parse(reader.ReadLine());
            string message;
           for(int i=0;i<repeats;i++)
            {
                string command = reader.ReadLine();
                string[] cmd = command.Split(' ');
                if (cmd[0] =="Drive")
                {
                    if (cmd[1]=="Car")
                    {
                        message = car.Drive(double.Parse(cmd[2]));
                        writer.WriteLine($"Car {message}");

                    }
                    else if (cmd[1]=="Truck")
                    {
                        message=truck.Drive(double.Parse(cmd[2]));
                        writer.WriteLine($"Truck {message}");
                    }
                }
                else if(cmd[0]=="Refuel")
                {
                    if (cmd[1] == "Car")
                    {
                        car.Refuel(double.Parse(cmd[2]));
                    }
                    else if (cmd[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(cmd[2]));
                    }
                }
               
            }
            writer.WriteLine(String.Format("Car: {0:f2}", car.FuelQuantity));
            writer.WriteLine(String.Format("Truck: {0:f2}", truck.FuelQuantity));

        }
    }
}
