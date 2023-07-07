using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("We have overridden car operations");
        }

        public bool HasSunroof { get; set; } = true;
    }
}
