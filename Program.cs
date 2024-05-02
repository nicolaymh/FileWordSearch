
using System.Text.RegularExpressions;






// Define the path to the source file
string sourceFilePath = @"../../../C#.md";

try
{
    // Check if the file exists at the specified path
    if (!File.Exists(sourceFilePath))
    {
        // Inform the user if the file does not exist and exit the program
        Console.WriteLine($"Error: the file '{sourceFilePath}' does not exist.");
        return;
    }

    // Read all text from the file into a string
    string data = File.ReadAllText(sourceFilePath);

    // Split the text into an array of words using Regex to handle all non-word characters as delimiters
    string[] words = Regex.Split(data, @"\W+");
    // Output the number of words found in the file
    Console.WriteLine($"Word count in 'C#.md': {words.Length}");

    // Count the occurrences of 'C#' in the text, ignoring case differences
    int CsharpWordCount = Regex.Matches(data, "C#", RegexOptions.IgnoreCase).Count;
    // Output the count of 'C#' occurrences
    Console.WriteLine($"Occurrences of 'C#': {CsharpWordCount}");
}

catch (IOException ex)
{
    // Handle I/O exceptions such as problems reading the file
    // Display the error related to file I/O operations
    Console.WriteLine($"I/O error while reading or writing the file: {sourceFilePath}");
    // Display the error message from the exception
    Console.WriteLine($"Error message: {ex.Message}");
    // Display the stack trace for more detailed error context
    Console.WriteLine($"Stack trace: {ex.StackTrace}");
}

catch (Exception ex)
{
    // Handle any other unexpected exceptions
    // Notify that an unexpected error has occurred
    Console.WriteLine("An unexpected error has occurred.");
    // Display the details of the exception
    Console.WriteLine($"Error details: {ex.Message}");
    // Display the location in the code where the error occurred
    Console.WriteLine($"Location in the code: {ex.StackTrace}");
}



