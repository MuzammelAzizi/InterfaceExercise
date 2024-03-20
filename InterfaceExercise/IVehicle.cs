using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        //Create 4 members that Car, Truck, & SUV all have in common.
        //* Example: public int NumberOfWheels { get; set; }
        public string Make { get; set; }

        public string Model { get; set; }

        public int DoorCount { get; set; }

        public double EngineSize { get; set; }
        public void DisplayDetails();
    }
}

