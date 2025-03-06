using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopCar.Models
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public int FuelConsumptionPer100km { get; set; }

        public Car(string brand, string model, int fuelConsumptionPer100km)
        {
            Brand = brand;
            Model = model;
            FuelConsumptionPer100km = fuelConsumptionPer100km;
        }

        public double CalculateFuelUsage(double distance)
        {
            return (FuelConsumptionPer100km * distance) / 100; 
        }

    }
}
