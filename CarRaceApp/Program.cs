using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarRaceApp
{
    class Program
    {
        public static bool RaceInProgress;
        public bool RedLight = true;
        public object PetrolStation  = new object();
        public List<Automobile> FinishOrder = new List<Automobile>();
        Random rnd = new Random();
        static void Main(string[] args)
        {
            Program prog = new Program();
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

            Automobile automobile1 = new Automobile("BC021DT", 4, 30, "manual", "Zastava", 1231231, 150, 1000, "limusine", "gasoline", "Blue",2);
            Automobile automobile2 = new Automobile("BC033KL", 4, 30, "manual", "Mitsubishi", 1245231, 170, 1000, "hatchback", "gasoline", "Red",3);
            List<Automobile> AutomobileList = new List<Automobile> { automobile1, automobile2};

            Automobile OrangeGolf = new Automobile("BC013MM", 4, 30, "manual", "Volkswagen", 1345231, 170, 1000, "hatchback", "diesel", "Orange",1);

            AutomobileList.Add(OrangeGolf);

            Thread Semaphore = new Thread(prog.SemaphoreMethod);
            foreach (var car in AutomobileList)
            {
                Console.WriteLine("{0} {1} is at the starting line.",car.colour,car.manufacturer);
            }
            Console.WriteLine("\t\t\t* * *");
            RaceInProgress = true;
            Semaphore.Start();
            foreach (var car in AutomobileList)
            {
                car.fuelLeft = prog.rnd.Next(5, car.tankVolume);
                car.carThread = new Thread(() => prog.RaceMethod(car));
                car.carThread.Start();
            }
            while (prog.FinishOrder.Count<3)
            {

            }
            RaceInProgress = false;
            Automobile Winner = (from x in prog.FinishOrder where x.colour.ToUpper() == "RED" select x).First();
            Console.WriteLine("{0} {1} won the race!",Winner.colour,Winner.manufacturer);
            Console.ReadLine();
        }

        public void SemaphoreMethod()
        {
            while (RaceInProgress == true)
            {
                Thread.Sleep(2000);
                if (RedLight == true)
                {
                    RedLight = false;
                    Console.WriteLine("Semaphore green");
                }
                else
                {
                    RedLight = true;
                    Console.WriteLine("Semaphore red");
                }
            }
        }

        public void RaceMethod(Automobile automobile)
        {
            Console.WriteLine("{0} {1} started the race.", automobile.colour, automobile.manufacturer);

            Thread.Sleep(10000);

            if (RedLight == true)
            {
                Console.WriteLine("{0} {1} is waiting on the red light.", automobile.colour, automobile.manufacturer);
                while (RedLight == true)
                {
                    Thread.Sleep(200);
                }
                Console.WriteLine("Red light turns to green and {0} {1} is in the race again.", automobile.colour, automobile.manufacturer);
            }

            Thread.Sleep(3000);

            if (automobile.fuelLeft < 15)
            {
                lock (PetrolStation)
                {
                    Console.WriteLine("{0} {1} is low on fuel and needs to stop at the petrol station.", automobile.colour, automobile.manufacturer);
                    automobile.fuelLeft = automobile.tankVolume;
                    Thread.Sleep(1000);
                    Console.WriteLine("{0} {1} is done tanking fuel and is in the race again.", automobile.colour, automobile.manufacturer);

                }
            }

            Thread.Sleep(7000);
            Console.WriteLine("{0} {1} has crossed the finish line.", automobile.colour, automobile.manufacturer);
            FinishOrder.Add(automobile);
        }
    }
}
