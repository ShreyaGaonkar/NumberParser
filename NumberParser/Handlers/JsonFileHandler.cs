using System.IO;
using Newtonsoft.Json;
using NumberParser.Interfaces;

namespace NumberParser.Handlers
{
    /// <summary>
    /// Provides functionality to persist an array of numbers to a JSON file.
    /// </summary>
    public class JsonFileHandler : IFileFormatHandler
    {
        /// <summary>
        /// Persists the given array of numbers to the specified JSON file.
        /// </summary>
        /// <param name="numbers">The array of numbers to be persisted.</param>
        /// <param name="filePath">The path to the JSON file.</param>
        public void Persist(int[] numbers, string filePath)
        {
            // Serialize the array of numbers to JSON format
            string jsonData = JsonConvert.SerializeObject(numbers);

            // Writes the JSON data to the specified file
            File.WriteAllText(filePath, jsonData);
        }
    }
}
