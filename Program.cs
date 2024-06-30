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

        try
        {
            
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            
            List<string> processedLines = new List<string>();
            foreach (var line in lines)
            {
                if (!line.Contains("skip", StringComparison.OrdinalIgnoreCase))
                {
                    processedLines.Add(line.ToUpper()); 
                }
            }

            
            processedLines.Sort();

            
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var processedLine in processedLines)
                {
                    writer.WriteLine(processedLine); 
                }
            }

            
            using (StreamWriter logWriter = new StreamWriter(logFilePath, true))
            {
                logWriter.WriteLine($"File processing completed successfully.");
            }
        }
        catch (FileNotFoundException ex)
        {
            
            using (StreamWriter logWriter = new StreamWriter(logFilePath, true))
            {
                logWriter.WriteLine($"Error: File not found - {ex.FileName}");
            }
        }
        catch (IOException ex)
        {
          
            using (StreamWriter logWriter = new StreamWriter(logFilePath, true))
            {
                logWriter.WriteLine($"I/O Error: {ex.Message}");
            }
        }
        catch (Exception ex)
        {
          
            using (StreamWriter logWriter = new StreamWriter(logFilePath, true))
            {
                logWriter.WriteLine($"General Error: {ex.Message}");
            }
        }
    }
}
