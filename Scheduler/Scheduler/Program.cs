using Autofac;
using Scheduler.Interfaces;
using Scheduler.Services;
using System;
using System.ServiceProcess;
using Topshelf;
using Topshelf.Autofac;

namespace Scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.UseAutofacContainer(BuildIoCAutofacContainer());

                x.Service<IMainLoggerService>(s => 
                {
                    s.ConstructUsingAutofacContainer();
                    s.WhenStarted((service, hostControl) => service.Start(hostControl));
                    s.WhenStopped((service, hostControl) => service.Stop(hostControl));
                });

                //x.Service<IQuartzSchedulerService>(s =>
                //{
                //    s.ConstructUsingAutofacContainer();
                //    s.WhenStarted((service, hostControl) => service.Start(hostControl));
                //    s.WhenStopped((service, hostControl) => service.Stop(hostControl));
                //});

                x.EnableServiceRecovery(r => r.RestartService(TimeSpan.FromSeconds(10)));
                x.SetServiceName("SchedulerCore");
                x.SetDisplayName("SchedulerCore");
                x.SetDescription("Usługa działająca w tle");
                x.StartAutomatically();
            });
            //ServiceBase.Run(new LoggingServiceBase(new LoggingService()));
        }

        private static ILifetimeScope BuildIoCAutofacContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<LoggingService>().As<ILoggingService>();
            builder.RegisterType<MainLoggerService>().As<IMainLoggerService>();
            builder.RegisterType<QuartzSchedulerService>().As<IQuartzSchedulerService>();
            var container = builder.Build();
            return container;
        }
    }
}
