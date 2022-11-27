using System;
using System.Windows.Forms;

namespace Kryzhevska_lab
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Kryzhevska_lab.Form1());
            Model model = new Model();
            /*model.ModelSet.Intensity = 0.8;
            model.ModelSet.MinValueOfBurstTime = 3;
            model.ModelSet.MaxValueOfBurstTime = 8;
            model.ModelSet.MinValueOfAddrSpace = 100;
            model.ModelSet.MaxValueOfAddrSpace = 300;
            model.ModelSet.ValueOfRAMSize = 32000;
            model.SaveSettings();

            for (int i = 0; i < 20; i++)
            {
                model.WorkingCycle();
                if (!model.cpu.IsFree())
                {
                    Console.WriteLine("On cpu: {0}", model.cpu.ActiveProcess);
                }

                if (!model.device.IsFree())
                {
                    Console.WriteLine("On device: {0}", model.device.ActiveProcess);
                }
            }*/
        }
    }
}
