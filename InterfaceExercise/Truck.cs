using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public double WeightCapacity { get; set; }

        public int WheelCount { get; set; }

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
