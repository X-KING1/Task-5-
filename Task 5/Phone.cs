// TASK 5: OOP

using System;

namespace BankAccountApp
{
    // derived class
    public class Smartphone : ElectronicDevice
    {
        // constructor
        public Smartphone(string brand, double price) : base(brand, price)
        {
        }

        // override abstract method
        public override void ShowInfo()
        {
            Console.WriteLine("Device: Smartphone");
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Price: Rs." + Price);
        }

        // extra method
        public void EnableCamera()
        {
            Console.WriteLine("Smartphone camera is enabled");
        }
    }
}
