using Scheduler.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Scheduler.Services
{
    class LoggingService : ILoggingService
    {
        private const string logFileLocation = @"C:\temp\servicelog.txt";

        public void Log(string logMessage)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(logFileLocation));
            File.AppendAllText(logFileLocation, $"{DateTime.Now} : {logMessage} {Environment.NewLine}");
        }
    }
}
