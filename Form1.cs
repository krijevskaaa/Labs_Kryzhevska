using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kryzhevska_lab
{
    public partial class Form1 : Form
    {
        private ViewDetailed viewDetailed;
        private bool appIsActive = false;
        public Form1()
        {
            InitializeComponent();
            viewDetailed = new ViewDetailed(new Model(), new Controller(), this);
            viewDetailed.DataBind();
            UpdateSettings();
            FirstPrepare();
        }
        private void FirstPrepare()
        {
            UpdateSettings();
            btn_start.Enabled = true;
            btn_endSession.Enabled = false;
            btn_working.Enabled = false;
            panel1.Enabled = true;
            rb_auto.Checked = false;
            rb_hands.Checked = true;
            appIsActive = false;
        }

        private void SessionPreparation()
        {
            btn_start.Enabled = false;
            btn_endSession.Enabled = true;
            btn_working.Enabled = rb_auto.Checked;
            panel1.Enabled = false;
            rb_auto.Enabled = false;
            rb_hands.Enabled = false;
        }

        private void EndOfSession()
        {
            btn_endSession.Enabled = false;
            btn_start.Enabled = true;
            btn_working.Enabled = false;
            panel1.Enabled = true;
            rb_hands.Enabled = true;
            rb_auto.Enabled = true;
        }

        private void UpdateSettings()
        {
            nud_intensity.Value = 0.5m;
            nud_minBurst.Value = nud_minBurst.Minimum;
            nud_maxBurst.Value = nud_maxBurst.Minimum;
            nud_minAdrSpace.Value = nud_minAdrSpace.Minimum;
            nud_maxAdrSpace.Value = nud_maxAdrSpace.Minimum;
            cb_sizeRAM.SelectedItem = cb_sizeRAM.Items[0];
        }

        private void btn_working_Click(object sender, EventArgs e)
        {
            viewDetailed.ReactToUserActions(ModelOperations.WorkingCycle);
        }

        private void btn_start_Click_1(object sender, EventArgs e)
        {
            SessionPreparation();
            appIsActive = true;
            viewDetailed.ReactToUserActions(ModelOperations.SaveSettings);
        }

        private void btn_endSession_Click(object sender, EventArgs e)
        {
            viewDetailed.ReactToUserActions(ModelOperations.EndOfSession);
            appIsActive = false;
            EndOfSession();
            UpdateSettings();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (rb_auto.Checked && appIsActive)
            {
                viewDetailed.ReactToUserActions(ModelOperations.WorkingCycle);
            }
        }

        private void lb_CPUQueueList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
