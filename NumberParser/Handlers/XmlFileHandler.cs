using NumberParser.Interfaces;
using System.Linq;
using System.Xml.Linq;

namespace NumberParser.Handlers
{
    /// <summary>
    /// Provides functionality to persist an array of numbers to an XML file.
    /// </summary>
    public class XmlFileHandler : IFileFormatHandler
    {
        /// <summary>
        /// Persists the given array of numbers to the specified XML file.
        /// </summary>
        /// <param name="numbers">The array of numbers to be persisted.</param>
        /// <param name="filePath">The path to the XML file.</param>
        public void Persist(int[] numbers, string filePath)
        {
            // Create an XML element for each number and wrap them inside a parent element
            XElement xmlNumbers = new XElement("Numbers", numbers.Select(n => new XElement("Number", n)));

            // Save the XML data to the specified file
            xmlNumbers.Save(filePath);
        }
    }
}
