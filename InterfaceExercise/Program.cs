using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */
            var honda = new Car();
            honda.Make = "Honda";
            honda.Model = "Civic";
            honda.Headquarters = "Japan";
            honda.Logo = "H";
            honda.EngineSize = 1.8;
            honda.DoorCount = 4;
            honda.HasTrunk = true;
            honda.IsSport = false;
            
            var tesla = new Truck();
            tesla.Headquarters = "Austin, TX, USA";
            tesla.Logo = "T";
            tesla.Make = "Tesla";
            tesla.Model = "CyberTruck";
            tesla.EngineSize = 6.0;
            tesla.DoorCount = 4;

            var benz = new Suv();
            benz.Headquarters = "Germany";
            benz.Logo = "+";
            benz.Make = "Mercedes Benz";
            benz.Model = "GLE";
            benz.EngineSize = 5.0;
            benz.DoorCount = 4;
            benz.IsAllWheelDrive = true;
            benz.IsHatchback = false;

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            honda.DisplayDetails();
            Console.WriteLine();
            tesla.DisplayDetails();
            Console.WriteLine();
            benz.DisplayDetails();
            Console.WriteLine();
        }
    }
}
