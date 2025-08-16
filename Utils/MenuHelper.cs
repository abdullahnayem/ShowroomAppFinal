
namespace VehicleShowroom.Utils
{
    public static class MenuHelper
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine("\n===== Vehicle Showroom Management =====");
            Console.WriteLine("1. Add Vehicle");
            Console.WriteLine("2. Remove Vehicle");
            Console.WriteLine("3. Show Vehicles");
            Console.WriteLine("4. Show Visitor Count");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
        }

        public static void ShowVehicleTypeMenu()
        {
            Console.WriteLine("\nSelect Vehicle Type:");
            Console.WriteLine("1. Normal Vehicle");
            Console.WriteLine("2. Sports Vehicle");
            Console.WriteLine("3. Heavy Vehicle");
        }
        public static void ShowEngineTypeMenu()
        {
            Console.WriteLine("Select Engine Type:");
            Console.WriteLine("1. Oil");
            Console.WriteLine("2. Gas");
            Console.WriteLine("3. Diesel");
        }
    }
}
