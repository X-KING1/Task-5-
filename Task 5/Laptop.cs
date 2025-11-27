// TASK 5: OOP

using System;

namespace BankAccountApp
{
    // derived class
    public class Laptop : ElectronicDevice
    {
        // constructor
        public Laptop(string brand, double price) : base(brand, price)
        {
        }

        // override abstract method
        public override void ShowInfo()
        {
            Console.WriteLine("Device: Laptop");
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Price: Rs." + Price);
        }

        // extra method
        public void TurnOnBattery()
        {
            Console.WriteLine("Laptop battery is turned on");
        }
    }
}
