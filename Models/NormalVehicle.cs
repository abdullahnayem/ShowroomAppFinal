using ShowroomApp.Models;

namespace VehicleShowroom.Models
{
    /// <summary>
    /// Represents a standard/normal vehicle in the showroom.
    /// Contains all basic vehicle properties without any special features.
    /// </summary>
    public class NormalVehicle : Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the NormalVehicle class.
        /// </summary>
        /// <param name="modelNumber">The unique model number of the vehicle.</param>
        /// <param name="engineType">The type of engine (Oil, Gas, or Diesel).</param>
        /// <param name="enginePower">The engine power specification.</param>
        /// <param name="tireSize">The tire size specification.</param>
        /// <param name="color">The color of the vehicle. Defaults to "White".</param>
        /// <param name="year">The manufacturing year. Defaults to 2025.</param>
        /// <param name="price">The price of the vehicle. Defaults to 0.</param>
        public NormalVehicle(string modelNumber, EngineType engineType, string enginePower, string tireSize, string color = "White", int year = 2025, double price = 0)
            : base(modelNumber, engineType, enginePower, tireSize, color, year, price)
        {
        }

        /// <summary>
        /// Returns a formatted string containing all details of the normal vehicle.
        /// </summary>
        /// <returns>A string representation of the normal vehicle details.</returns>
        public override string GetDetails()
        {
            return $"Normal Vehicle | Model: {ModelNumber} | Engine: {EngineType} | Power: {EnginePower} | Tire: {TireSize} | Color: {Color} | Year: {Year} | Price: ${Price}";
        }
    }
}
