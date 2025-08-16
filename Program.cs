using ShowroomApp.Models;
using VehicleShowroom.Models;
using VehicleShowroom.Services;
using VehicleShowroom.Utils;

class Program
{
    static void Main()
    {
        Showroom showroom = new Showroom();

        while (true)
        {
            MenuHelper.ShowMainMenu();
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
        MenuHelper.ShowVehicleTypeMenu();
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
