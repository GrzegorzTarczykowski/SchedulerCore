﻿using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceProcess;
using System.Text;
using Topshelf;

namespace Scheduler
{
    class LoggingService : ServiceBase //ServiceControl
    {
        private const string _logFileLocation = @"C:\temp\servicelog.txt";

        private void Log(string logMessage)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(_logFileLocation));
            File.AppendAllText(_logFileLocation, DateTime.UtcNow.ToString() + " : " + logMessage + Environment.NewLine);
        }

        protected override void OnStart(string[] args)
        {
            Log("Starting");
            base.OnStart(args);
        }

        protected override void OnStop()
        {
            Log("Stopping");
            base.OnStop();
        }

        protected override void OnPause()
        {
            Log("Pausing");
            base.OnPause();
        }

        //public bool Start(HostControl hostControl)
        //{
        //    Log("Starting");
        //    return true;
        //}

        //public bool Stop(HostControl hostControl)
        //{
        //    Log("Stopping");
        //    return true;
        //}
    }
}