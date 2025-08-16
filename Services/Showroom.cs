using VehicleShowroom.Models;

namespace VehicleShowroom.Services
{
    /// <summary>
    /// Manages the vehicle showroom operations including adding, removing, and displaying vehicles.
    /// Tracks expected visitor count which increases when sports vehicles are added.
    /// </summary>
    public class Showroom
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        private int expectedVisitors = 30;

        private const int VISITOR_INCREASTED_COUNT = 20;

        public int VehicleCount => vehicles.Count;

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            if (vehicle is SportsVehicle) expectedVisitors += VISITOR_INCREASTED_COUNT;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n +++ Vehicle '{vehicle.ModelNumber}' added successfully!\n");
            Console.ResetColor();
        }

        /// <summary>
        /// Removes a vehicle from the showroom by its model number.
        /// </summary>
        /// <param name="modelNumber">The model number of the vehicle to remove.</param>
        public void RemoveVehicle(string modelNumber)
        {
            var vehicle = vehicles.FirstOrDefault(v => v.ModelNumber == modelNumber);
            if (vehicle != null)
            {
                vehicles.Remove(vehicle);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n ### Vehicle '{modelNumber}' removed successfully!\n");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("\n Vehicle not found.\n");
            }
        }

        /// <summary>
        /// Displays all vehicles in the showroom in a formatted table with color coding.
        /// </summary>
        public void ShowVehicles()
        {
            Console.WriteLine("\n-------------------------------- Vehicle List --------------------------------");
            Console.WriteLine($"{"Type",-15} {"Model",-15} {"Engine",-10} {"Power",-10} {"Tire",-10} {"Extra",-25}");
            Console.WriteLine("-------------------------------------------------------------------------------");

            foreach (var v in vehicles)
            {
                if (v is SportsVehicle sv)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{"Sports",-15} {sv.ModelNumber,-15} {sv.EngineType,-10} {sv.EnginePower,-10} {sv.TireSize,-10} Turbo: {(sv.Turbo ? "Yes" : "No"),-15}");
                }
                else if (v is HeavyVehicle hv)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{"Heavy",-15} {hv.ModelNumber,-15} {hv.EngineType,-10} {hv.EnginePower,-10} {hv.TireSize,-10} Weight: {hv.Weight}T");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{"Normal",-15} {v.ModelNumber,-15} {v.EngineType,-10} {v.EnginePower,-10} {v.TireSize,-10} {"-",-25}");
                }
                Console.ResetColor();
            }

            Console.WriteLine("-------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Displays the current expected visitor count for the showroom.
        /// </summary>
        public void ShowVisitorCount()
        {
            Console.WriteLine($"\nExpected Visitors: {expectedVisitors}\n");
        }
    }
}
