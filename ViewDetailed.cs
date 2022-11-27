using Queues;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kryzhevska_lab
{
    class ViewDetailed : View
    {
        private Form1 frm;
        public ViewDetailed(Model model, Controller controller, Form1 frm) :
        base(model, controller)
        {
            this.frm = frm;
        }

        private void PropertyChangedHandler(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ReadyQueue")
            {
                updateListBox(model.ReadyQueue, frm.lb_CPUQueueList);
            }
            else if (e.PropertyName == "Device1Queue")
            {
                updateListBox(model.Device1Queue, frm.lb_Device1QueueList);
            }
            else
            {
                updateListBox(model.Device2Queue, frm.lb_Device2QueueList);
            }
        }

        public override void DataBind()
        {
            //привязка счетчика тактов
            frm.tb_takts.DataBindings.Add(new Binding("Text", model._clock, "Clock"));

            //привязка активного процесса(процесор)
            frm.lb_CPUQueueList.DataBindings.Add(new Binding("Text", model._cpu, "CPUQueueList"));

            //привязка активного процесса(внешнее устройство 1)
            frm.lb_Device1QueueList.DataBindings.Add(new Binding("Text", model._device1, "ActiveProcess"));
            
            //привязка активного процесса(внешнее устройство 2)
            //frm.lb_Device2QueueList.DataBindings.Add(new Binding("Text", model._device2, "ActiveProcess"));

            //свободная память
            frm.tb_freeRAM.DataBindings.Add(new Binding("Text", model._ram, "FreeSize"));

            //занятая память процессами
            frm.tb_occupiedRAM.DataBindings.Add(new Binding("Text", model._ram, "OccupiedSize"));


            Binding intensityBinding = new Binding("Value", model.ModelSettings, "nud_intensity");
            intensityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.nud_intensity.DataBindings.Add(intensityBinding);

            Binding burstMinBinding = new Binding("Value", model.ModelSettings, "nud_minBurst");
            intensityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.nud_minBurst.DataBindings.Add(burstMinBinding);

            Binding burstMaxBinding = new Binding("Value", model.ModelSettings, "MaxValueOfBurstTime");
            intensityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.nud_maxBurst.DataBindings.Add(burstMaxBinding);

            Binding addrSpaceMinBinding = new Binding("Value", model.ModelSettings, "MinValueOfAddrSpace");
            addrSpaceMinBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.nud_minAdrSpace.DataBindings.Add(addrSpaceMinBinding);

            Binding addrSpaceMaxBinding = new Binding("Value", model.ModelSettings, "MaxValueOfAddrSpace");
            addrSpaceMaxBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.nud_maxAdrSpace.DataBindings.Add(addrSpaceMaxBinding);

            Binding ramSizeBinding = new Binding("SelectedItem", model.ModelSettings, "ValueOfRAMSize", true);
            ramSizeBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.cb_sizeRAM.DataBindings.Add(ramSizeBinding);

            Subscribe();
        }
        public override void DataUnbind() { }

        // подписчик
        private void Subscribe()
        {
            model.PropertyChanged += new PropertyChangedEventHandler(PropertyChangedHandler);
        }
        private void Unsubscribe()
        {
            model.PropertyChanged -= PropertyChangedHandler;
        }
        private void updateListBox(IQueueable<Process> queue, ListBox lb)
        {
            lb.Items.Clear();
            if (queue.Count != 0)
            {
                lb.Items.AddRange(queue.ToArray());
            }
        }

    }
}
