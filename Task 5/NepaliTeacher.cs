// TASK 3: POLYMORPHISM

using System;

namespace BankAccountApp
{
    // child class inherits from Teacher
    public class NepaliTeacher : Teacher
    {
        // overriding Teaching method from base class
        public override void Teaching()
        {
            Console.WriteLine("Nepali teacher teaches in Nepali language");
        }
    }
}
