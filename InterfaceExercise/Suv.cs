using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany
    {
        public bool IsHatchback { get; set; }
        public bool IsAllWheelDrive { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int DoorCount { get; set; }
        public double EngineSize { get; set; }
        public string Headquarters { get; set; }
        public string Logo { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Car information\n");
            Console.WriteLine($"Make: {Make}\nModel: {Model}\nHeadquarters: {Headquarters}\nLogo: {Logo}\nEngineSize: {EngineSize}\nDoorCount: {DoorCount}");
        }
    }
}
