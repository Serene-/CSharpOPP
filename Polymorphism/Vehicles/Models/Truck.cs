using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
            airConditionerConsumption = 1.6;
        }

        public override void Refuel(double fuel)
        {
            FuelQuantity += fuel * 0.95;
        }
        //public override string Drive(double distance)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append("Truck ")
        //        .Append(DriveConsump(distance, airConditionerConsumption));
        //    return sb.ToString();
        //}

    }
}
