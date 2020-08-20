using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRaceApp
{
    abstract class MotorVehicle
    {
        public double engineDisplacemet;
        public int weight;
        public string category;
        public string engineType;
        public string colour;

        public MotorVehicle(double ED, int W, string C, string ET, string Col)
        {
            engineDisplacemet = ED;
            weight = W;
            category = C;
            engineType = ET;
            colour = Col;
        }

        void Go()
        {
            Console.WriteLine("Vehicle has started moving.");
        }

        void Stop()
        {
            Console.WriteLine("Vehicle has stopped moving.");
        }
    }
}
