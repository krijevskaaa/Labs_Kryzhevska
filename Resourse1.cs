using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using System.ComponentModel;

namespace Kryzhevska_lab
{
    public class Resourse: INotifyPropertyChanged
    {
        private Process activeProcess;
        public Process ActiveProcess
        {
            get { return activeProcess; }
            set { activeProcess = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged()
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("ActiveProcess"));
            }
        }

        public void WorkingCycle()
        {
            if (!IsFree())
            {
                activeProcess.IncreaseWorkTime();
            }
        }

        [Pure]
        public bool IsFree()
        {
            return activeProcess == null;
        }

        public void Clear()
        {
            ActiveProcess = null;
        }
    }
}