using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamProcessing
{
    internal class Writer
    {

        public void Write(string filePath, List<string> lines)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var line in lines)
                {
                    writer.WriteLine(line);
                }
                string logContent = string.Join(Environment.NewLine, lines);
                Logs.Log($"Final result of writing input.txt contains:{logContent}", Logs.GetLogFilePath());
            }
        }
    }
}
