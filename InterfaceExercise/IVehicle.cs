using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public bool AutoTrans { get; set; }
        public int NumberOfSeats { get; set; }
        public string Color { get; set; }
    }

   

}
