using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public  int Year { get; set; } = 1;
        public  string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Camry";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {Make} {Model} is virtually operating.");
        }


    }
}
