using System;
using System.IO;
using System.Linq;
using NumberParser.Factory;
using NumberParser.Interfaces;

namespace NumberParser
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitRequested = false;

            while (!exitRequested)
            {
                try
                {
                    // Display usage instructions
                    Console.WriteLine("Input Format: NumberParser <comma delimited list of integers> <file format>");

                    // Read user input
                    string input = Console.ReadLine();

                    // Split the input string by space
                    string[] parts = input.Split(' ');

                    // Ensure input contains three parts and is in the correct format
                    if (parts.Length != 3 ||
                        string.IsNullOrWhiteSpace(parts[1]) ||
                        string.IsNullOrWhiteSpace(parts[2]) ||
                        !parts[1].Split(',').All(str => int.TryParse(str.Trim(), out _)))
                    {
                        Console.WriteLine("Invalid input. Please provide input in 'NumberParser <comma delimited list of integers> <file format>' format");
                        continue; // Continue to next iteration of the loop
                    }

                    // Extract numbers and file format from the input string
                    string numbersInput = parts[1];
                    string fileFormat = parts[2]?.ToLowerInvariant();

                    // Parse the comma-delimited list of integers
                    int[] numbers = numbersInput.Split(',')
                                                .Select(str => int.Parse(str.Trim()))
                                                .ToArray();

                    // Sort the numbers in descending order
                    Array.Sort(numbers);
                    Array.Reverse(numbers);

                    // Define the output file path
                    string dateTimeString = DateTime.Now.ToString("yyyyMMddHHmmss");
                    string fileName = $"output_{dateTimeString}.{fileFormat}"; // Appending current datetime to the file name
                    string downloadsFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                    string outputFile = Path.Combine(downloadsFolder, "Downloads", fileName);

                    // Display the path where the file will be saved
                    Console.WriteLine($"Saving file to: {outputFile}");

                    // Get the appropriate file format handler
                    IFileFormatHandler handler = FileFormatFactory.GetHandler(fileFormat);

                    // Check if handler is null
                    if (handler != null)
                    {
                        // Persist the numbers to the specified file format
                        handler.Persist(numbers, outputFile);
                        Console.WriteLine($"Numbers sorted in descending order have been persisted to {outputFile}.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

                Console.WriteLine("Do you want to continue? (Y/N)");
                string response = Console.ReadLine()?.ToUpperInvariant();

                if (response != "Y")
                {
                    exitRequested = true;
                }
            }
        }
    }
}
