using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public bool Has4X4 { get; set; }
        public int BedSize { get; set; }

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
