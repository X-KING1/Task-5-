// TASK 3: POLYMORPHISM

using System;

namespace BankAccountApp
{
    // base class
    public class Teacher
    {
        // property
        public string Name { get; set; }

        // method that can be overridden by child classes
        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // method that cannot be overridden by child classes
        public void SalaryInfo()
        {
            Console.WriteLine("Teacher salary is fixed");
        }
    }
}
