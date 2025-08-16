using ShowroomApp.Models;
using VehicleShowroom.Models;
using VehicleShowroom.Services;
using VehicleShowroom.Utils;

/// <summary>
/// Main program class for the Vehicle Showroom Management System.
/// Provides a console-based interface for managing vehicles in the showroom.
/// </summary>
class Program
{
    /// <summary>
    /// The main entry point of the application.
    /// Runs an interactive console menu for vehicle showroom management.
    /// </summary>
    static void Main()
    {
        Showroom showroom = new Showroom();

        while (true)
        {
            Console.WriteLine("\n===== Vehicle Showroom Management =====");
            Console.WriteLine("1. Add Vehicle");
            Console.WriteLine("2. Remove Vehicle");
            Console.WriteLine("3. Show Vehicles");
            Console.WriteLine("4. Show Visitor Count");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddVehicleMenu(showroom);
                    break;

                case "2":
                    if (showroom.VehicleCount == 0)
                        Console.WriteLine("\n *** No vehicles available to remove.\n");
                    else
                    {
                        string model = InputHelper.ReadRequiredString("Enter model number to remove: ");
                        showroom.RemoveVehicle(model);
                    }
                    break;

                case "3":
                    showroom.ShowVehicles();
                    break;

                case "4":
                    showroom.ShowVisitorCount();
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    /// <summary>
    /// Displays the vehicle addition menu and handles user input for creating new vehicles.
    /// </summary>
    /// <param name="showroom">The showroom instance to add vehicles to.</param>
    static void AddVehicleMenu(Showroom showroom)
    {
        Console.WriteLine("\nSelect Vehicle Type:");
        Console.WriteLine("1. Normal Vehicle");
        Console.WriteLine("2. Sports Vehicle");
        Console.WriteLine("3. Heavy Vehicle");
        string type = InputHelper.ReadRequiredString("Choice: ");

        string model = InputHelper.ReadRequiredString("Enter Model Number: ");
        string power = InputHelper.ReadRequiredString("Enter Engine Power: ");
        string tire = InputHelper.ReadRequiredString("Enter Tire Size: ");

        if (type == "1")
        {
            EngineType engine = InputHelper.ReadEngineType();
            showroom.AddVehicle(new NormalVehicle(model, engine, power, tire));
        }
        else if (type == "2")
        {
            bool turbo = InputHelper.ReadYesNo("Turbo available? (Y/N): ");
            showroom.AddVehicle(new SportsVehicle(model, power, tire, turbo));
        }
        else if (type == "3")
        {
            double weight = InputHelper.ReadDouble("Enter Weight in tons: ");
            showroom.AddVehicle(new HeavyVehicle(model, power, tire, weight));
        }
        else
        {
            Console.WriteLine("Invalid type!");
        }
    }
}
