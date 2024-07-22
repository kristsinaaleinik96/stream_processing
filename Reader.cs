using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamProcessing
{
    public class Reader
    {
        public List<string> ReadLines(string filePath)
        {
            List<string> lines = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
                string logContent = string.Join(Environment.NewLine, lines);
                Logs.Log($"File input.txt contains next text:\n {logContent}", Logs.GetLogFilePath());
            }
            catch (FileNotFoundException ex)
            {
                Logs.Log($"Input file not found: {ex.Message}", Logs.GetLogFilePath());
            }
            catch (IOException ex)
            {
                Logs.Log($"I/O Error: {ex.Message}", Logs.GetLogFilePath());
            }
            return lines;
        }
    }
}
