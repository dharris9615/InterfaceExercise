using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }

        public bool HasNavigation { get; set; }
        public string Trunksize { get; set; }

        public int NumberOfWheels { get ; set ; }
        public bool AutoTrans { get ; set ; }
        public int NumberOfSeats { get ; set ; }
        public string Color { get ; set ; }

        public bool Domestic { get ; set ; }
        public string Logo { get ; set ; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }
    }
}
