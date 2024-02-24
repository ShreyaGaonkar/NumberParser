Factory Pattern:

1. FileFormatFactory: This class serves as a factory to create different file format handlers based on the provided file format.
2. GetHandler(): This method within the factory takes the desired file format as input and returns the appropriate handler for that format.
3. Usage: In the main program, we use the FileFormatFactory to get the specific handler needed for the input file format. This way, the creation of handlers is separated from their usage, making the code more modular and easier to maintain.

Interfaces:

1. IFileFormatHandler: This interface defines the rules for handling sorted integers in different file formats.
2. Handlers.TextFileHandler, Handlers.XmlFileHandler, Handlers.JsonFileHandler: These classes implement the IFileFormatHandler interface and handle the persistence of sorted integers in text, XML, and JSON formats, respectively.
3. Usage: In the main program, we interact with instances of IFileFormatHandler without needing to know the internal details of each handler. This allows us to work with different file formats using a unified interface, promoting code flexibility and reusability.

How to Use the Application:

1. Compile the Code: Compile the provided C# code to create an executable file (e.g., NumberParser.exe).
2. Run the Application: Open a command prompt or terminal and navigate to the directory containing the compiled executable.
3. Follow Usage Instructions: When running the application, it will display usage instructions. These instructions specify the required input format, such as providing a comma-delimited list of integers followed by the desired file format (e.g., "NumberParser 4,5,1,9,10,58,34,12,0 XML").
4. Input: Enter the comma-delimited list of integers and the desired file format according to the usage instructions.
5. Output: The application will sort the provided integers in descending order, save them to a file in the specified format (text, XML, or JSON), and show the file path where the data is saved.
6. Continue or Exit: After processing the input, the application will ask if you want to continue or exit. Type "Y" to continue providing input or "N" to exit the application.
