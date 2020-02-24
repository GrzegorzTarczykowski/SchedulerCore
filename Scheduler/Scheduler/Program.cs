using System;
using System.ServiceProcess;
using Topshelf;

namespace Scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceBase.Run(new LoggingService());

            //HostFactory.Run(x =>
            //{
            //    x.Service<LoggingService>();
            //    x.EnableServiceRecovery(r => r.RestartService(TimeSpan.FromSeconds(10)));
            //    x.SetServiceName("SchedulerCore");
            //    x.StartAutomatically();
            //});
        }
    }
}
