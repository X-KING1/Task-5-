// TASK 5: OOP

using System;

namespace BankAccountApp
{
    // abstract class
    public abstract class ElectronicDevice
    {
        // private fields
        private string brand;
        private double price;

        // constructor
        public ElectronicDevice(string b, double p)
        {
            brand = b;
            price = p;
        }

        // public properties
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        // abstract method
        public abstract void ShowInfo();
    }
}
