using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        //In each of your Car, Truck, and SUV classes

        //* Create 2 members that are specific to each class
        //* Example for Car: public bool HasTrunk { get; set; }
        //* Example for SUV: public int NumberOfSeats { get; set; }        
        //* Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
        public bool HasTrunk {  get; set; }
        public bool IsSport { get; set; }
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
