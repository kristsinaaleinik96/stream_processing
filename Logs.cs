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
        private static string? LogFilePath;
        public Logs(string logFilePath)
        {
            LogFilePath = logFilePath;
        }

        public static string? GetLogFilePath()
        {
            return LogFilePath;
        }

        public static void Log(string message, string? logFilePath)
        {
            using (StreamWriter logWriter = new StreamWriter(logFilePath, true))
            {
                logWriter.WriteLine($"Time of event: {DateTime.Now:dd-MM-yyyy HH:mm:ss}. Message: {message} ");
            }
        }
    }
}
