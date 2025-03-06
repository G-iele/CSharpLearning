//Skalbimo Mašinos Energijos Sąnaudų Skaičiavimas
//Užduotis:
//Sukurkite klasę WashingMachine, kuri turės savybes:
//Brand(gamintojas)
//Model(modelis)
//EnergyConsumptionPerCycle(energijos suvartojimas per vieną skalbimo ciklą, kWh)
//Sukurkite konstruktorių, kuris inicializuos visas šias reikšmes.
//Sukurkite metodą CalculateTotalEnergyUsage(int cycles), kuris apskaičiuos ir grąžins bendrą
//sunaudotą energiją per nurodytą ciklų skaičių.
//Programoje sukurkite WashingMachine objektą, apskaičiuokite sunaudotą energiją per 15 skalbimo ciklų ir išveskite rezultatą.

using OopWashingMachine.Models;

namespace OopWashingMachine
{
    public class Program
    {
        public static void Main()
        {
            WashingMachine washingMachine = new WashingMachine("Philips", "R1", 20);
            Console.WriteLine($"{washingMachine.Brand} | {washingMachine.Model} | {washingMachine.CalculateTotalEnergyUsage(15)}");
        }
    }
}