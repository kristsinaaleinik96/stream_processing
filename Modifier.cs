using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamProcessing
{
    internal class Modifier
    {
        public List<string> SkipLinesContaining(List<string> lines, string substring)
        {
            List<string> filteredLines = new List<string>();
            try
            {
                foreach (var line in lines)
                {
                    if (!line.Contains(substring))
                    {
                        filteredLines.Add(line);
                    }
                }
                string logContent = string.Join(Environment.NewLine, filteredLines);
                Logs.Log($"File input.txt was filtered and contains next text:{logContent}", Logs.GetLogFilePath());
                return filteredLines;
            }
            catch (IOException ex)
            {
                Logs.Log($"I/O Error: {ex.Message}", Logs.GetLogFilePath());
            }
            catch (Exception ex)
            {
                Logs.Log($"Unknown error: {ex.Message}", Logs.GetLogFilePath());
            }
            return new List<string>();
        }
        public List<string> SortLines(List<string> lines)
        {
            try
            {
                lines.Sort();
                string logContent = string.Join(Environment.NewLine, lines);
                Logs.Log($"File input.txt was sorted and contains next text:{logContent}", Logs.GetLogFilePath());
                return lines;
            }
            catch (Exception ex)
            {
                Logs.Log($"Unknown error: {ex.Message}", Logs.GetLogFilePath());
            }
            return new List<string>();
        }

        public List<string> ToUpperCase(List<string> lines)
        {
            List<string> upperLines = new List<string>();
            try
            {
                foreach (var line in lines)
                {
                    upperLines.Add(line.ToUpper());
                }
                string logContent = string.Join(Environment.NewLine, upperLines);
                Logs.Log($"File input.txt has been converted to uppercase and contains next text:{logContent}", Logs.GetLogFilePath());
                return upperLines;
            }
            catch (Exception ex)
            {
                Logs.Log($"Unknown error: {ex.Message}", Logs.GetLogFilePath());
            }
            return new List<string>();
        }
    }
}
