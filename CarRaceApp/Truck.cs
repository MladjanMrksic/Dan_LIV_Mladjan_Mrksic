using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRaceApp
{
    class Truck : MotorVehicle
    {        
        public double freightCapacity;
        public double height;
        public int seatNumber;

        public Truck(double FC, double H, int SN, double ED, int W, string C, string ET, string Col) : base(ED,W,C,ET,Col)
        {
            freightCapacity = FC;
            height = H;
            seatNumber = SN;
        }

        void Load()
        {
            Console.WriteLine("Truck is loaded.");
        }
        void Unload()
        {
            Console.WriteLine("Truck has unloaded.");
        }
    }
}
