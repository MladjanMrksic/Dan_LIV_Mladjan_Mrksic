using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorVehicle truck1 = new Truck(200, 2000, 4, 500.50, 2000, "freight", "diesel", "gray");
            MotorVehicle truck2 = new Truck(200, 2000, 4, 500.50, 2000, "freight", "diesel", "red");
            Queue<MotorVehicle> TruckQueue = new Queue<MotorVehicle>();
            TruckQueue.Enqueue(truck1);
            TruckQueue.Enqueue(truck2);

            MotorVehicle tractor1 = new Tractor(50, 150, "rear", 300.50, 1500, "hauler", "petrol", "green");
            MotorVehicle tractor2 = new Tractor(50, 150, "rear", 300.50, 1500, "hauler", "petrol", "black");
            Stack<MotorVehicle> TractorStack = new Stack<MotorVehicle>();
            TractorStack.Push(tractor1);
            TractorStack.Push(tractor2);

            MotorVehicle automobile1 = new Automobile("BC021DT", 4, 30, "manual", "Zastava", 1231231, 150, 1000, "limusine", "gasoline", "blue");
            MotorVehicle automobile2 = new Automobile("BC033KL", 4, 30, "manual", "Mitsubishi", 1245231, 170, 1000, "hatchback", "gasoline", "red");
            List<MotorVehicle> AutomobileList = new List<MotorVehicle> { automobile1, automobile2};
        }
    }
}
