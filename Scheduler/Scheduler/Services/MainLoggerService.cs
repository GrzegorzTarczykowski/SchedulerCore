using Scheduler.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Topshelf;

namespace Scheduler.Services
{
    class MainLoggerService : IMainLoggerService
    {
        private readonly ILoggingService loggingService;

        public MainLoggerService(ILoggingService loggingService)
        {
            this.loggingService = loggingService;
        }

        public bool Start(HostControl hostControl)
        {
            loggingService.Log("Starting");
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            loggingService.Log("Stopping");
            return true;
        }
    }
}
