using NumberParser.Interfaces;
using System.IO;

namespace NumberParser.Handlers
{
    /// <summary>
    /// Provides functionality to persist an array of numbers to a text file.
    /// </summary>
    public class TextFileHandler : IFileFormatHandler
    {
        /// <summary>
        /// Persists the given array of numbers to the specified text file.
        /// </summary>
        /// <param name="numbers">The array of numbers to be persisted.</param>
        /// <param name="filePath">The path to the text file.</param>
        public void Persist(int[] numbers, string filePath)
        {
            // Convert the array of numbers to a comma-separated string and write it to the file
            File.WriteAllText(filePath, string.Join(",", numbers));
        }
    }
}
