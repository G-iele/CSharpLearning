//Automobilio Klasė su Kuro Sąnaudų Skaičiavimu
//Užduotis:
//Sukurkite klasę Car, kuri turės šias savybes:
//Brand(gamintojas)
//Model(modelis)
//FuelConsumptionPer100km(kuro sąnaudos 100 km)
//Sukurkite konstruktorių, kuris inicializuos visas šias reikšmes.
//Sukurkite metodą CalculateFuelUsage(double distance), kuris apskaičiuos ir grąžins reikalingą
//kuro kiekį tam tikram atstumui nuvažiuoti.
//Programoje sukurkite automobilio objektą, apskaičiuokite kuro sunaudojimą 350 km ir išveskite rezultatą.

using OopCar.Models;

namespace OopCar
{
    public class Program
    {
        public static void Main()
        {
            Car car = new Car("Volvo", "Nice model", 12);
            Console.WriteLine($"Brand: {car.Brand} | Model: {car.Model} | Takes fuel for 50 km: {car.CalculateFuelUsage(50)}");
        }
    }
}