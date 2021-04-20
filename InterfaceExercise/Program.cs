using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var platinum = new Truck() {Make = "Ford",Model = "Platinum", NumberOfSeats = 4, AutoTrans = true, Color = "silver", NumberOfWheels = 4, BedSize = 5, Domestic = true, Has4X4 = true, Logo = "FORD"};
            var M3 = new Car() {Make = "BMW", Model = "M3", NumberOfSeats = 5, AutoTrans = false, Color = "green", NumberOfWheels = 4, HasNavigation = true, Domestic = false, Logo = "BMW", Trunksize = "Small" };
            var tahoe = new SUV() {Make = "Chevy", Model = "Tahoe", NumberOfSeats = 6, AutoTrans = true, Color = "black", NumberOfWheels = 4, Domestic = true, Logo = "Chevy", CargoLimit = 500, HasDVD = true };

            var auto = new List<IVehicle>();


            auto.Add(platinum);
            auto.Add(M3);
            auto.Add(tahoe);

            foreach(var veh in auto)
            {
                Console.WriteLine($"Make: {veh.Make}, Model: {veh.Model}, has an Auto Transmission {veh.AutoTrans}, Is {veh.Color}, has {veh.NumberOfWheels} wheels, and has {veh.NumberOfSeats} seats");
                Console.WriteLine();

            }

            var comp = new List<ICompany>();

            comp.Add(platinum);
            comp.Add(M3);
            comp.Add(tahoe);

            foreach(var item in comp)
            {
                Console.WriteLine($"Has the {item.Logo} Logo , Is a Domestic made vehicle {item.Domestic}.");
                Console.WriteLine();
            }

        }
    }
}
