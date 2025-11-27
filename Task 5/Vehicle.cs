// TASK 2: INHERITANCE

using System;

namespace BankAccountApp
{
    // base class
    public class Vehicle
    {
        // properties
        public string Brand { get; set; }
        public int Speed { get; set; }

        // methods
        public void Start()
        {
            Console.WriteLine(Brand + " is starting...");
        }

        public void Stop()
        {
            Console.WriteLine(Brand + " has stopped.");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Speed: " + Speed + " km/h");
        }
    }
}
