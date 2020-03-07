using Quartz;
using Quartz.Impl;
using Scheduler.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Scheduler.Services
{
    class QuartzSchedulerService : IQuartzSchedulerService
    {
        public bool Start(HostControl hostControl)
        {
            throw new NotImplementedException();
        }

        public bool Stop(HostControl hostControl)
        {
            throw new NotImplementedException();
        }
    }
}
