using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRaceApp
{
    class Automobile : MotorVehicle
    {
        public string registrationNumber;
        public int numberOfDoors;
        public int tankVolume;
        public string transmissionType;
        public string manufacturer;
        public int traficLicenseNumber;

        public Automobile(string RN, int NOD, int TV, string TT, string Man, int TLN, double ED, int W, string C, string ET, string Col) : base(ED,W,C,ET,Col)
        {
            registrationNumber = RN;
            numberOfDoors = NOD;
            tankVolume = TV;
            transmissionType = TT;
            manufacturer = Man;
            traficLicenseNumber = TLN;
        }

        void Repaint(string newColour)
        {
            Console.WriteLine("Vehicle changed colour from {0} to {1}",colour,newColour);
            colour = newColour;
        }
    }
}
