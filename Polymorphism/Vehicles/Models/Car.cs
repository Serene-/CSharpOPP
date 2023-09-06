using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        //private const double airConditionerConsumption = 0.9 ;
        public Car(double fuelQuantity, double fuelConsumption) :base(fuelQuantity, fuelConsumption)
        {
            airConditionerConsumption = 0.9;
        }
        public override void Refuel(double fuel)
        {
            FuelQuantity = FuelQuantity + fuel;
        }
        //public override string Drive(double distance)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append("Car ")
        //        .Append(DriveConsump(distance, airConditionerConsumption));
        //    return sb.ToString();
        //}
    }
}
