using System;

namespace BankAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Bank Account
            Console.WriteLine("--- Task 1: Bank Account ---");
            BankAccount myAccount = new BankAccount("12345", 1000);

            Console.WriteLine("Account Number: " + myAccount.AccountNumber);
            Console.WriteLine("Balance: " + myAccount.Balance);
            Console.WriteLine();

            Console.WriteLine("Depositing 500...");
            myAccount.Deposit(500);
            Console.WriteLine("Balance after deposit: " + myAccount.Balance);
            Console.WriteLine();

            Console.WriteLine("Withdrawing 300...");
            myAccount.Withdraw(300);
            Console.WriteLine("Remaining balance: " + myAccount.Balance);
            Console.WriteLine();
            Console.WriteLine();

            // Task 2: Inheritance
            Console.WriteLine("--- Task 2: Inheritance ---");
            
            // create Car object
            Car myCar = new Car();
            myCar.Brand = "Toyota";
            myCar.Speed = 180;
            myCar.Seats = 5;

            Console.WriteLine("Car Info:");
            myCar.Start();
            myCar.DisplayInfo();
            myCar.Stop();
            Console.WriteLine();

            // create Motorcycle object
            Motorcycle myBike = new Motorcycle();
            myBike.Brand = "Honda";
            myBike.Speed = 200;
            myBike.Type = "Sport";

            Console.WriteLine("Motorcycle Info:");
            myBike.Start();
            myBike.DisplayInfo();
            myBike.Stop();
            Console.WriteLine();
            Console.WriteLine();

            // Task 3: Polymorphism
            Console.WriteLine("--- Task 3: Polymorphism ---");
            
            // create NepaliTeacher object
            NepaliTeacher teacher1 = new NepaliTeacher();
            teacher1.Name = "Ram Sharma";
            Console.WriteLine("Name: " + teacher1.Name);
            teacher1.Teaching();
            teacher1.SalaryInfo();
            Console.WriteLine();

            // create EnglishTeacher object
            EnglishTeacher teacher2 = new EnglishTeacher();
            teacher2.Name = "John Smith";
            Console.WriteLine("Name: " + teacher2.Name);
            teacher2.Teaching();
            teacher2.SalaryInfo();
            Console.WriteLine();
            Console.WriteLine();

            // Task 4: Abstraction
            Console.WriteLine("--- Task 4: Abstraction ---");

            // create Car object
            CarAbstract car = new CarAbstract();
            car.Display();
            car.StartEngine();
            car.StopEngine();
            Console.WriteLine();

            // create Bike object
            Bike bike = new Bike();
            bike.Display();
            bike.StartEngine();
            bike.StopEngine();
            Console.WriteLine();
            Console.WriteLine();

            // Task 5: OOP
            Console.WriteLine("--- Task 5: OOP ---");

            // create ElectronicsStore object
            ElectronicsStore store = new ElectronicsStore();

            // create Laptop and Smartphone objects
            Laptop laptop = new Laptop("Dell", 50000);
            Smartphone phone = new Smartphone("Samsung", 30000);

            // add devices to store
            store.AddDevice(laptop);
            store.AddDevice(phone);
            Console.WriteLine();

            // show all device details
            store.ShowAllDeviceDetails();
        }
    }
}
