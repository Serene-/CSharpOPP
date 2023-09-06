using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        protected double airConditionerConsumption;
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelConsumption = fuelConsumption;
            FuelQuantity = fuelQuantity;
        }
        public double FuelConsumption { get; private set; }

        public double FuelQuantity {get; protected set;}

        public abstract void Refuel(double fuel);
        public string Drive(double distance)
        {
            double neededFuel = distance * (FuelConsumption + airConditionerConsumption);
            if (FuelQuantity >= neededFuel)
            {
                FuelQuantity -= neededFuel;
                return $"travelled {distance} km";
            }
            else return "needs refuelin";
        }
    }
}
