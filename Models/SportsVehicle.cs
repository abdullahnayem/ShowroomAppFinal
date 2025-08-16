using ShowroomApp.Models;
namespace VehicleShowroom.Models
{
    /// <summary>
    /// Represents a sports vehicle in the showroom.
    /// Features turbo capability and is restricted to oil-based engines only.
    /// </summary>
    public class SportsVehicle : Vehicle
    {
        /// <summary>
        /// Gets or sets whether the sports vehicle has turbo capability.
        /// </summary>
        public bool Turbo { get; set; }

        /// <summary>
        /// Initializes a new instance of the SportsVehicle class.
        /// Sports vehicles are automatically configured with oil-based engines.
        /// </summary>
        /// <param name="modelNumber">The unique model number of the vehicle.</param>
        /// <param name="enginePower">The engine power specification.</param>
        /// <param name="tireSize">The tire size specification.</param>
        /// <param name="turbo">Whether the vehicle has turbo capability.</param>
        /// <param name="color">The color of the vehicle. Defaults to "Red".</param>
        /// <param name="year">The manufacturing year. Defaults to 2025.</param>
        /// <param name="price">The price of the vehicle. Defaults to 0.</param>
        public SportsVehicle(string modelNumber, string enginePower, string tireSize, bool turbo, string color = "Red", int year = 2025, double price = 0)
            : base(modelNumber, EngineType.Oil, enginePower, tireSize, color, year, price)
        {
            Turbo = turbo;
        }

        /// <summary>
        /// Returns a formatted string containing all details of the sports vehicle including turbo status.
        /// </summary>
        /// <returns>A string representation of the sports vehicle details.</returns>
        public override string GetDetails()
        {
            return $"Sports Vehicle | Model: {ModelNumber} | Engine: {EngineType} | Power: {EnginePower} | Tire: {TireSize} | Turbo: {(Turbo ? "Yes" : "No")} | Color: {Color} | Year: {Year} | Price: ${Price}";
        }
    }
}
