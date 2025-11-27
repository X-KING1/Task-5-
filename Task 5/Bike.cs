// TASK 4: ABSTRACTION

using System;

namespace BankAccountApp
{
    // derived class
    public class Bike : AbstractVehicle
    {
        // implement abstract method
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started");
        }

        // implement abstract method
        public override void StopEngine()
        {
            Console.WriteLine("Bike engine stopped");
        }
    }
}
