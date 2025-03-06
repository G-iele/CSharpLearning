using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopWashingMachine.Models
{
    public class WashingMachine
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public int EnergyConsumptionPerCycle { get; set; }

        public WashingMachine (string brand, string model, int energyConsumptionPerCycle)
        {
            Brand = brand;
            Model = model;
            EnergyConsumptionPerCycle = energyConsumptionPerCycle;
        }

        public double CalculateTotalEnergyUsage(int cycles)
        {
            return EnergyConsumptionPerCycle * cycles;
        }
    }
}
