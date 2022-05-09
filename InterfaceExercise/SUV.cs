using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise 
{
    internal class SUV : ICompany, IVehicle
    {
        public int RowCount { get; set; }
        public string OffRoadCapable { get; set; }

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
