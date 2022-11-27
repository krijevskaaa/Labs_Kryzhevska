using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kryzhevska_lab
{
    enum ProcessStatus { ready, running, waiting, terminated }

    class Process : IComparable<Process>
    {
        public long id;
        public string name;
        public long workTime;
        public Random rand = new Random();

        public event EventHandler FreeingAResource;

        public void OnFreeResource(object sender, EventArgs e)
        {
            if (FreeingAResource != null)
            {
                FreeingAResource(sender, e);
            }
        }
        public long BurstTime { get; set; }
        public ProcessStatus Status { get; set; }
        public long AddrSpace { get; }
        public Process(long pId, long addrSpace)
        {
            id = pId;
            name = "p" + id;
            AddrSpace = addrSpace;
            Status = ProcessStatus.ready;
        }

        public void IncreaseWorkTime()
        {
            if (workTime < BurstTime)
            {
                workTime++;
                //return;
            }
            else
            {
                if (Status == ProcessStatus.running)
                {
                    Status = rand.Next(0, 2) == 0 ? ProcessStatus.terminated : ProcessStatus.waiting;
                }
                else
                {
                    Status = ProcessStatus.ready;
                }
                OnFreeResource(this, null);
            }

        }
        public void ResetWorkTime()
        {
            workTime = 0;
        }
        public override string ToString()
        {
            return "Process ID: " + id +
                   "; Process Name: " + name +
                   "; Process Burst Time: " + BurstTime +
                "; Process Status: " + Status +
               "; Process Address Space: " + AddrSpace + ";";

            // добавить workTime
        }

        
        public int CompareTo(Process otherProc)
        {
            if (otherProc == null)
            {
                return 1;
            }
            return otherProc.BurstTime.CompareTo(BurstTime);
        }
    }


    /*class Process : IComparable, IComparable<Process>
    {
        private long _id;
        private string _name;
        private long _workTime;
        private Random rnd;

        public long BurstTime { get; set; }
        internal ProcessStatus ProcessStatus { get; set; }
        internal long AddressSpace { get; }
        public event EventHandler FreeingAResource;

        public Process(long pId, long pAddressSpace)
        {
            _id = pId;
            AddrSpace = pAddressSpace;
            Status = ProcessStatus.Ready;
            _name = "Process " + pId;
            rnd = new Random();
        }
        public void IncreaseWorkTime()
        {
            if (_workTime < BurstTime)
            {
                _workTime++;
            }
            else
            {
                if (Status == ProcessStatus.Running)
                {
                    Status = rnd.Next(0, 2) == 0 ? ProcessStatus.terminated : ProcessStatus.waiting;
                }
                else
                {
                    Status = ProcessStatus.ready;
                }
                OnFreeingAResource(this, null);
            }
        }

        public void ResetWorkTime()
        {
            _workTime = 0;
        }

        public override string ToString()
        {
            return "Process ID: " + _id +
                   "; Process Name: " + _name +
                   "; Process Status: " + Status +
                   "; Process Address Space: " + AddrSpace +
                   "; Process Burst Time: " + BurstTime + ";";
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Process otherProcess = obj as Process;
            if (otherProcess != null)
            {
                if (BurstTime < otherProcess.BurstTime)
                    return -1;
                return BurstTime < otherProcess.BurstTime ? 1 : 0;
            }
            throw new ArgumentException("Object is not a Process");
        }
        public int CompareTo(Process other)
        {
            if (other == null)
            {
                return 1;
            }
            return other.BurstTime.CompareTo(BurstTime);
        }

        private void OnFreeingAResource(object sender, EventArgs e)
        {
            if (FreeingAResource != null)
            {
                FreeingAResource(sender, e);
            }
        }

    }
    public enum ProcessStatus
    {
        ready,
        running,
        waiting,
        terminated
    }*/
}

