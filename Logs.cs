using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamProcessing
{
    internal class Logs
    {
        private string LogFilePath;
        public Logs(string LogFilePath)
        {
            this.LogFilePath = LogFilePath;
        }

        public void Log(string message)
        {
            using (StreamWriter logWriter = new StreamWriter(LogFilePath, true))
            {
                logWriter.WriteLine($"Time of event: {DateTime.Now:dd-MM-yyyy} {message} ");
            }
        }
    }
}
