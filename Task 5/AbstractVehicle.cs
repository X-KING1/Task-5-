// TASK 4: ABSTRACTION

using System;

namespace BankAccountApp
{
    // abstract class
    public abstract class AbstractVehicle
    {
        // abstract methods
        public abstract void StartEngine();
        public abstract void StopEngine();

        // concrete method
        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
}
