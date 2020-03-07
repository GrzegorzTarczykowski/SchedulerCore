using Scheduler.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceProcess;
using System.Text;

namespace Scheduler.Services
{
    class LoggingServiceBase : ServiceBase
    {
        private readonly ILoggingService loggingService;

        public LoggingServiceBase(ILoggingService loggingService)
        {
            this.loggingService = loggingService;
        }

        protected override void OnStart(string[] args)
        {
            ServiceName = nameof(LoggingServiceBase);
            loggingService.Log("Starting");
            base.OnStart(args);
        }

        protected override void OnStop()
        {
            loggingService.Log("Stopping");
            base.OnStop();
        }

        protected override void OnPause()
        {
            loggingService.Log("Pausing");
            base.OnPause();
        }
    }
}
