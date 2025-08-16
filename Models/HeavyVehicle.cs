using ShowroomApp.Models;
namespace VehicleShowroom.Models
{
    /// <summary>
    /// Represents a heavy vehicle in the showroom.
    /// Features weight specification and is restricted to diesel engines only.
    /// </summary>
    public class HeavyVehicle : Vehicle
    {
        /// <summary>
        /// Gets or sets the weight of the heavy vehicle in tons.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Initializes a new instance of the HeavyVehicle class.
        /// Heavy vehicles are automatically configured with diesel engines.
        /// </summary>
        /// <param name="modelNumber">The unique model number of the vehicle.</param>
        /// <param name="enginePower">The engine power specification.</param>
        /// <param name="tireSize">The tire size specification.</param>
        /// <param name="weight">The weight of the vehicle in tons.</param>
        /// <param name="color">The color of the vehicle. Defaults to "Grey".</param>
        /// <param name="year">The manufacturing year. Defaults to 2025.</param>
        /// <param name="price">The price of the vehicle. Defaults to 0.</param>
        public HeavyVehicle(string modelNumber, string enginePower, string tireSize, double weight, string color = "Grey", int year = 2025, double price = 0)
            : base(modelNumber, EngineType.Diesel, enginePower, tireSize, color, year, price)
        {
            Weight = weight;
        }

        /// <summary>
        /// Returns a formatted string containing all details of the heavy vehicle including weight.
        /// </summary>
        /// <returns>A string representation of the heavy vehicle details.</returns>
        public override string GetDetails()
        {
            return $"Heavy Vehicle | Model: {ModelNumber} | Engine: {EngineType} | Power: {EnginePower} | Tire: {TireSize} | Weight: {Weight}T | Color: {Color} | Year: {Year} | Price: ${Price}";
        }
    }
}
