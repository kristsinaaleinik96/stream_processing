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

        
        var reader = new Reader();
        lines = reader.ReadLines(inputFilePath);

        var modifier = new Modifier();
        var filteredLines = modifier.SkipLinesContaining(lines, "skip");
        var sortedLines = modifier.SortLines(filteredLines);
        var upperLines = modifier.ToUpperCase(sortedLines);
        var writer = new Writer();
        writer.Write(outputFilePath, upperLines);
    }
}