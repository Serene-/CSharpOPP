using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models.Interfaces
{
    public interface IVehicle
    {
        double FuelConsumption { get; }
        double FuelQuantity { get; }
        void Refuel(double fuel);
        string Drive(double distance);
    }
}
