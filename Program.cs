using StreamProcessing;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {

        string inputFilePath = "input.txt";

        string outputFilePath = "output.txt";

        string logFilePath = "log.txt";

        List<string> lines = new List<string>();
        var logger = new Logs(logFilePath);

        try
        {
            var reader = new Reader();
            lines = reader.ReadLines(inputFilePath);
            logger.Log("File reading completed successfully.");

            var modifier = new Modifier();
            var sortedLines = modifier.SortLines(lines);
            logger.Log("File sorting completed successfully.");

            var upperLines = modifier.ToUpperCase(sortedLines);
            logger.Log("File conversion to uppercase completed successfully.");

            var writer = new Writer();
            writer.Write(outputFilePath, upperLines);
            logger.Log("File writing completed successfully.");


        }
        catch (FileNotFoundException ex)
        {
            logger.Log($"Input file not found: {ex.Message}");
        }
        catch (IOException ex)
        {
            logger.Log($"I/O Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            logger.Log($"Unknown error: {ex.Message}");
        }
    }
}