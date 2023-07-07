using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {

        public int NumberOfWheels { get; set; } = 2;

        public override void DriveAbstract()
        {
            Console.WriteLine($"Overrides motorcycle operations");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("decided to use the method");
        }
    }
}
