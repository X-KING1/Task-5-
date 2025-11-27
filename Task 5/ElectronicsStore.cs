// TASK 5: OOP

using System;
using System.Collections.Generic;

namespace BankAccountApp
{
    public class ElectronicsStore
    {
        // list to store devices
        private List<ElectronicDevice> devices;

        // constructor
        public ElectronicsStore()
        {
            devices = new List<ElectronicDevice>();
        }

        // method to add device
        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine("Device added to store");
        }

        // method to remove device
        public void RemoveDevice(ElectronicDevice device)
        {
            devices.Remove(device);
            Console.WriteLine("Device removed from store");
        }

        // method to show all devices
        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("All Devices in Store:");
            for (int i = 0; i < devices.Count; i++)
            {
                Console.WriteLine();
                devices[i].ShowInfo();

                // downcast and call child specific methods
                if (devices[i] is Laptop)
                {
                    Laptop lap = (Laptop)devices[i];
                    lap.TurnOnBattery();
                }
                else if (devices[i] is Smartphone)
                {
                    Smartphone phone = (Smartphone)devices[i];
                    phone.EnableCamera();
                }
            }
        }
    }
}
