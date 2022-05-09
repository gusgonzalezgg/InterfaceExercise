using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : ICompany, IVehicle
    {
        public string Sedan { get; set; }

        public string Coupe { get; set; }

        // ICompany Interface Inherited Members
        public string Name { get; set; }
        public string Model { get; set; }
        public string Hood { get; set; }

        // IVehicle Interface Inherited Members
        public string SteeringWheel { get; set; }
        public int MilesPerGallon { get; set; }
        public string Bluetooth { get; set; }
    }
}
