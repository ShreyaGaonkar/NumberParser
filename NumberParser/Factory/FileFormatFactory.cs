using System;

namespace NumberParser.Factory
{
    /// <summary>
    /// Factory class responsible for creating file format handlers based on the specified format.
    /// </summary>
    public static class FileFormatFactory
    {
        /// <summary>
        /// Retrieves the appropriate file format handler based on the given format.
        /// </summary>
        /// <param name="format">The format of the file.</param>
        /// <returns>An instance of a file format handler.</returns>
        /// <exception cref="NotSupportedException">Thrown when an unsupported file format is provided.</exception>
        public static Interfaces.IFileFormatHandler GetHandler(string format)
        {
            switch (format.ToLower())
            {
                case "text":
                    return new Handlers.TextFileHandler();
                case "xml":
                    return new Handlers.XmlFileHandler();
                case "json":
                    return new Handlers.JsonFileHandler();
                default:
                    throw new NotSupportedException("Unsupported file format. Only XML, text and JSON formats are supported.");
            }
        }
    }
}
