using ShowroomApp.Models;

namespace VehicleShowroom.Utils
{
    /// <summary>
    /// Provides utility methods for reading and validating user input from the console.
    /// Ensures data integrity by implementing proper validation and error handling.
    /// </summary>
    public static class InputHelper
    {
        /// <summary>
        /// Reads a required string input from the console with validation.
        /// </summary>
        /// <param name="prompt">The prompt message to display to the user.</param>
        /// <returns>A non-empty, trimmed string value.</returns>
        public static string ReadRequiredString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var s = Console.ReadLine()?.Trim();
                if (!string.IsNullOrWhiteSpace(s)) return s!;
                Console.WriteLine("    Please enter a non-empty value.");
            }
        }

        /// <summary>
        /// Reads an integer input from the console with optional range validation.
        /// </summary>
        /// <param name="prompt">The prompt message to display to the user.</param>
        /// <param name="min">Optional minimum allowed value.</param>
        /// <param name="max">Optional maximum allowed value.</param>
        /// <returns>A valid integer within the specified range.</returns>
        public static int ReadInt(string prompt, int? min = null, int? max = null)
        {
            while (true)
            {
                Console.Write(prompt);
                var s = Console.ReadLine();
                if (int.TryParse(s, out int val))
                {
                    if (min.HasValue && val < min.Value) { Console.WriteLine($"    Minimum allowed: {min.Value}"); continue; }
                    if (max.HasValue && val > max.Value) { Console.WriteLine($"    Maximum allowed: {max.Value}"); continue; }
                    return val;
                }
                Console.WriteLine("    Please enter a valid integer.");
            }
        }

        /// <summary>
        /// Reads a double input from the console with optional range validation.
        /// </summary>
        /// <param name="prompt">The prompt message to display to the user.</param>
        /// <param name="min">Optional minimum allowed value.</param>
        /// <param name="max">Optional maximum allowed value.</param>
        /// <returns>A valid double within the specified range.</returns>
        public static double ReadDouble(string prompt, double? min = null, double? max = null)
        {
            while (true)
            {
                Console.Write(prompt);
                var s = Console.ReadLine();
                if (double.TryParse(s, out double val))
                {
                    if (min.HasValue && val < min.Value) { Console.WriteLine($"    Minimum allowed: {min.Value}"); continue; }
                    if (max.HasValue && val > max.Value) { Console.WriteLine($"    Maximum allowed: {max.Value}"); continue; }
                    return val;
                }
                Console.WriteLine("    Please enter a valid number.");
            }
        }

        /// <summary>
        /// Reads a yes/no input from the console with validation.
        /// </summary>
        /// <param name="prompt">The prompt message to display to the user.</param>
        /// <returns>True for yes (Y/y/Yes/yes), False for no (N/n/No/no).</returns>
        public static bool ReadYesNo(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var s = Console.ReadLine()?.Trim().ToLowerInvariant();
                if (s == "y" || s == "yes") return true;
                if (s == "n" || s == "no") return false;
                Console.WriteLine(" Enter Y/N (Yes/No).");
            }
        }

        /// <summary>
        /// Reads an engine type selection from the console with validation.
        /// </summary>
        /// <returns>A valid EngineType enum value.</returns>
        public static EngineType ReadEngineType()
        {
            while (true)
            {
                MenuHelper.ShowEngineTypeMenu();
                string input = Console.ReadLine();
                if (int.TryParse(input, out int val) && Enum.IsDefined(typeof(EngineType), val))
                {
                    return (EngineType)val;
                }
                Console.WriteLine(" Invalid engine type. Try again.");
            }
        }
    }
}
