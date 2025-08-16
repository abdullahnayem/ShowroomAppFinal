using ShowroomApp.Models;

namespace VehicleShowroom.Models
{
    /// <summary>
    /// Base abstract class representing a vehicle in the showroom.
    /// Provides common properties and behavior for all vehicle types.
    /// </summary>
    /// <remarks>
    /// This class serves as the foundation for the vehicle inheritance hierarchy.
    /// All vehicle types must implement the GetDetails() method.
    /// </remarks>
    public abstract class Vehicle
    {
        public string ModelNumber { get; set; }
        
        /// <summary>
        /// Gets or sets the type of engine (Oil, Gas, or Diesel).
        /// </summary>
        public EngineType EngineType { get; set; }
        public string EnginePower { get; set; }
        public string TireSize { get; set; }

        // Extra optional properties
        /// <summary>
        /// Gets or sets the color of the vehicle.
        /// Default value is "White".
        /// </summary>
        public string Color { get; set; }
        
        /// <summary>
        /// Gets or sets the manufacturing year of the vehicle.
        /// Default value is 2025.
        /// </summary>
        public int Year { get; set; }
        
        /// <summary>
        /// Gets or sets the price of the vehicle in currency units.
        /// Default value is 0.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the Vehicle class with the specified parameters.
        /// </summary>
        /// <param name="modelNumber">The unique model number of the vehicle.</param>
        /// <param name="engineType">The type of engine (Oil, Gas, or Diesel).</param>
        /// <param name="enginePower">The engine power specification.</param>
        /// <param name="tireSize">The tire size specification.</param>
        /// <param name="color">The color of the vehicle. Defaults to "White".</param>
        /// <param name="year">The manufacturing year. Defaults to 2025.</param>
        /// <param name="price">The price of the vehicle. Defaults to 0.</param>
        public Vehicle(string modelNumber, EngineType engineType, string enginePower, string tireSize, string color = "White", int year = 2025, double price = 0)
        {
            ModelNumber = modelNumber;
            EngineType = engineType;
            EnginePower = enginePower;
            TireSize = tireSize;
            Color = color;
            Year = year;
            Price = price;
        }

        /// <summary>
        /// Abstract method to retrieve the details of the vehicle.
        /// Implementations should provide specific details for the derived vehicle type.
        /// </summary>
        /// <returns>A string containing the details of the vehicle.</returns>
        public abstract string GetDetails();
    }
}
