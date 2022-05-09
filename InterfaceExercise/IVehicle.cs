using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public string Hood { get; set; }
        public string SteeringWheel { get; set; }
        public int MilesPerGallon { get; set; }

        public string Bluetooth { get; set; }
    }
}
