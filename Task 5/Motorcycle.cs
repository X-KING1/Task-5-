// TASK 2: INHERITANCE

using System;

namespace BankAccountApp
{
    // derived class from Vehicle
    public class Motorcycle : Vehicle
    {
        // unique field for Motorcycle
        public string Type { get; set; }

        // override DisplayInfo method
        public override void DisplayInfo()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Speed: " + Speed + " km/h");
            Console.WriteLine("Type: " + Type);
        }
    }
}
