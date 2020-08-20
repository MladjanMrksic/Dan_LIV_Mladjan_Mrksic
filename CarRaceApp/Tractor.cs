using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRaceApp
{
    class Tractor : MotorVehicle
    {
        public double tireSize;
        public int wheelbase;
        public string propulsion;

        public Tractor(double TS, int Wheel, string P, double ED, int W, string C, string ET, string Col) : base(ED,W,C,ET,Col)
        {
            tireSize = TS;
            wheelbase = Wheel;
            propulsion = P;
        }
    }
}
