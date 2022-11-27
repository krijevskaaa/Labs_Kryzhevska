using Queues;
using Structures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kryzhevska_lab
{
    class Model: INotifyPropertyChanged
    {
        public SystemClock _clock;
        
        public Resourse _cpu;
       
        public Resourse _device1;
        public Resourse _device2;
        private IDGenerator _idGen;
        private CPUScheduler _cpuScheduler;
        private DeviceScheduler _deviceScheduler;
        public Memory _ram;
        private MemoryManager _memoryManager;
        private Random _processRand;
        public Settings ModelSettings { get; set; }
        private IQueueable<Process> _readyQueue;
        private IQueueable<Process> _deviceQueue;
        private Random _random = new Random();

        public event PropertyChangedEventHandler PropertyChanged;

        public Model()
        {
            _clock = new SystemClock();
            _cpu = new Resourse();
            _device1 = new Resourse();
            _device2 = new Resourse();
            _ram = new Memory();
            _idGen = new IDGenerator();
            _readyQueue = new PriorityQueue<Process, BinaryHeap<Process>>(new BinaryHeap<Process>());
            _deviceQueue = new FIFOQueue<Process, QueueableList<Process>>(new QueueableList<Process>());
            _cpuScheduler = new CPUScheduler(_cpu, _readyQueue);
            _memoryManager = new MemoryManager();
            _deviceScheduler = new DeviceScheduler(_device1, _deviceQueue);
            //_deviceScheduler = new DeviceScheduler(_device1, _deviceQueue);
            _processRand = new Random();
            ModelSettings = new Settings();
        }

        public void SaveSettings()
        {
            _ram.Save(ModelSettings.ValueOfRamSize);
            _memoryManager.Save(_ram);
        }

        public void WorkingCycle()
        {
            _clock.WorkingCycle();
            if (_processRand.NextDouble() <= ModelSettings.Intensity)
            {
                Process proc = new Process(_idGen.Id,
                    _processRand.Next(ModelSettings.MinValueOfAddrSpace, ModelSettings.MaxValueOfAddrSpace + 1));
                if (_memoryManager.Allocate(proc) != null)
                {
                    proc.BurstTime = _processRand.Next(ModelSettings.MinValueOfBurstTime,
                        ModelSettings.MaxValueOfBurstTime + 1);
                    Subscribe(proc);
                    _readyQueue.Put(proc);
                    if (_cpu.IsFree())
                    {
                        _cpuScheduler.Session();
                    }
                }
            }
            _cpu.WorkingCycle();
            _device1.WorkingCycle();
        }

        public void Clear()
        {
            _cpu.Clear();
            _device1.Clear();
            _ram.Clear();
            _readyQueue.Clear();
            _deviceQueue.Clear();
        }

        private void FreeingAResourceEventHandler(object sender, EventArgs e)
        {
            Process p = sender as Process;
            switch (p.Status)
            {
                case ProcessStatus.ready:
                    _device1.Clear();

                    p.BurstTime = _processRand.Next(ModelSettings.MinValueOfBurstTime,
                        ModelSettings.MaxValueOfBurstTime + 1);
                    p.ResetWorkTime();
                    _readyQueue = _readyQueue.Put(p);
                    if (_cpu.IsFree())
                    {
                        _cpuScheduler.Session();
                    }
                    if (_deviceQueue.Count != 0)
                    {
                        _deviceQueue = _deviceScheduler.Session();
                    }
                    break;
                case ProcessStatus.terminated:
                    _cpu.Clear();
                    _memoryManager.Free(p);
                    Unsubscribe(p);
                    break;
                case ProcessStatus.waiting:
                    _cpu.Clear();
                    p.BurstTime = _processRand.Next(ModelSettings.MinValueOfBurstTime,
                        ModelSettings.MaxValueOfBurstTime + 1);
                    p.ResetWorkTime();
                    _deviceQueue = _deviceQueue.Put(p);
                    if (_device1.IsFree())
                    {
                        _deviceScheduler.Session();
                    }
                    if (_readyQueue.Count != 0)
                    {
                        _cpuScheduler.Session();
                    }
                    break;
                default:
                    break;
            }
        }

        private void Subscribe(Process p)
        {
            if (p != null)
            {
                p.FreeingAResource += FreeingAResourceEventHandler;
            }
        }

        private void Unsubscribe(Process p)
        {
            if (p != null)
            {
                p.FreeingAResource -= FreeingAResourceEventHandler;
            }
        }
        public IQueueable<Process> ReadyQueue
        {
            get { return _readyQueue; }
            set { _readyQueue = value; OnPropertyChanged(); }
        }
        public IQueueable<Process> Device1Queue
        {
            get { return _deviceQueue; }
            set { _readyQueue = value; OnPropertyChanged(); }
        }
        public IQueueable<Process> Device2Queue
        {
            get { return _deviceQueue; }
            set { _readyQueue = value; OnPropertyChanged(); }
        }
        
        private void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
