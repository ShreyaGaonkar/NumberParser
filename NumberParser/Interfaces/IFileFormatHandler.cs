namespace NumberParser.Interfaces
{
    /// <summary>
    /// Interface for handling persistence of an array of numbers to various file formats.
    /// </summary>
    public interface IFileFormatHandler
    {
        /// <summary>
        /// Persists the given array of numbers to the specified file.
        /// </summary>
        /// <param name="numbers">The array of numbers to be persisted.</param>
        /// <param name="filePath">The path to the file.</param>
        void Persist(int[] numbers, string filePath);
    }
}
