using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRaceApp
{
    abstract class MotorVehicle
    {
        double engineDisplacemet;
        int weight;
        string category;
        string engineType;
        string colour;

        void Go() { }

        void Stop() { }
    }
}
