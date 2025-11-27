// TASK 2: INHERITANCE
// TASK 4: ABSTRACTION (CarAbstract class)

using System;

namespace BankAccountApp
{
    // derived class from Vehicle for Task 2
    public class Car : Vehicle
    {
        // unique field for Car
        public int Seats { get; set; }

        // override DisplayInfo method
        public override void DisplayInfo()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Speed: " + Speed + " km/h");
            Console.WriteLine("Seats: " + Seats);
        }
    }

    // derived class from AbstractVehicle for Task 4
    public class CarAbstract : AbstractVehicle
    {
        // implement abstract method
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }

        // implement abstract method
        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}
