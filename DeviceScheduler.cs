using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queues;

namespace Kryzhevska_lab
{
    class DeviceScheduler
    {
        private Resourse _resourse;
        private IQueueable<Process> _queue;

        public DeviceScheduler(Resourse resourse, IQueueable<Process> queue)
        {
            _resourse = resourse;
            _queue = queue;
        }

        public IQueueable<Process> Session()
        {
            Process newActiveProcess = _queue.Item();
            _queue.Remove();
            _resourse.ActiveProcess = newActiveProcess;
            return _queue;
        }
    }
}
