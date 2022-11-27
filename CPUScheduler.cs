using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queues;


namespace Kryzhevska_lab
{
    class CPUScheduler
    {
        private Resourse _resource;
        private IQueueable<Process> _queue;

        public CPUScheduler(Resourse resource, IQueueable<Process> queue)
        {
            _resource = resource;
            _queue = queue;
        }

        public IQueueable<Process> Session()
        {
            Process process = _queue.Item();
            process.Status = ProcessStatus.running;
            _queue.Remove();
            _resource.ActiveProcess = process;
            return _queue;
        }
    }
}
