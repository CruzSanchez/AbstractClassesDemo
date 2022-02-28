using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Vehicles



            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            Car nissan = new Car() { HasSunroof = false, Make = "Nissan", Model = "Altima", Year = 2019 };
            Motorcycle coolFriend = new Motorcycle() { NumberOfWheels = 3, Make = "European", Model = "Vintage", Year = 1985 };
            Vehicle explorer = new Car() { HasSunroof = true, Make = "Ford", Model = "Explorer", Year = 2010 };
            Vehicle coolFriend2 = new Motorcycle() { NumberOfWheels = 2, Make = "European2", Model = "Vintage2" };



            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(nissan);
            vehicles.Add(explorer);
            vehicles.Add(coolFriend);
            vehicles.Add(coolFriend2);

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"Make {vehicle.Make}, Model {vehicle.Model}, Year: {veh.Year}");
                vehicle.DriveAbstract();
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
