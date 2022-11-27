
namespace Kryzhevska_lab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_intensity = new System.Windows.Forms.NumericUpDown();
            this.nud_minBurst = new System.Windows.Forms.NumericUpDown();
            this.nud_maxBurst = new System.Windows.Forms.NumericUpDown();
            this.cb_sizeRAM = new System.Windows.Forms.ComboBox();
            this.nud_minAdrSpace = new System.Windows.Forms.NumericUpDown();
            this.nud_maxAdrSpace = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_endSession = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_working = new System.Windows.Forms.Button();
            this.lb_Device2QueueList = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rb_hands = new System.Windows.Forms.RadioButton();
            this.rb_auto = new System.Windows.Forms.RadioButton();
            this.tb_occupiedRAM = new System.Windows.Forms.TextBox();
            this.tb_freeRAM = new System.Windows.Forms.TextBox();
            this.tb_takts = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Device1QueueList = new System.Windows.Forms.ListBox();
            this.lb_CPUQueueList = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_intensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minBurst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxBurst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minAdrSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxAdrSpace)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // nud_intensity
            // 
            this.nud_intensity.DecimalPlaces = 1;
            this.nud_intensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            resources.ApplyResources(this.nud_intensity, "nud_intensity");
            this.nud_intensity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_intensity.Name = "nud_intensity";
            // 
            // nud_minBurst
            // 
            resources.ApplyResources(this.nud_minBurst, "nud_minBurst");
            this.nud_minBurst.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_minBurst.Name = "nud_minBurst";
            this.nud_minBurst.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_maxBurst
            // 
            resources.ApplyResources(this.nud_maxBurst, "nud_maxBurst");
            this.nud_maxBurst.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_maxBurst.Name = "nud_maxBurst";
            this.nud_maxBurst.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_sizeRAM
            // 
            this.cb_sizeRAM.FormattingEnabled = true;
            this.cb_sizeRAM.Items.AddRange(new object[] {
            resources.GetString("cb_sizeRAM.Items"),
            resources.GetString("cb_sizeRAM.Items1"),
            resources.GetString("cb_sizeRAM.Items2"),
            resources.GetString("cb_sizeRAM.Items3"),
            resources.GetString("cb_sizeRAM.Items4")});
            resources.ApplyResources(this.cb_sizeRAM, "cb_sizeRAM");
            this.cb_sizeRAM.Name = "cb_sizeRAM";
            // 
            // nud_minAdrSpace
            // 
            resources.ApplyResources(this.nud_minAdrSpace, "nud_minAdrSpace");
            this.nud_minAdrSpace.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_minAdrSpace.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_minAdrSpace.Name = "nud_minAdrSpace";
            this.nud_minAdrSpace.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_maxAdrSpace
            // 
            resources.ApplyResources(this.nud_maxAdrSpace, "nud_maxAdrSpace");
            this.nud_maxAdrSpace.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_maxAdrSpace.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_maxAdrSpace.Name = "nud_maxAdrSpace";
            this.nud_maxAdrSpace.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nud_intensity);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nud_maxBurst);
            this.panel2.Controls.Add(this.label3);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.nud_minBurst);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.nud_maxAdrSpace);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cb_sizeRAM);
            this.panel5.Controls.Add(this.label4);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.nud_minAdrSpace);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_endSession);
            this.panel7.Controls.Add(this.btn_start);
            this.panel7.Controls.Add(this.btn_working);
            this.panel7.Controls.Add(this.lb_Device2QueueList);
            this.panel7.Controls.Add(this.listBox5);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.rb_hands);
            this.panel7.Controls.Add(this.rb_auto);
            this.panel7.Controls.Add(this.tb_occupiedRAM);
            this.panel7.Controls.Add(this.tb_freeRAM);
            this.panel7.Controls.Add(this.tb_takts);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.lb_Device1QueueList);
            this.panel7.Controls.Add(this.lb_CPUQueueList);
            this.panel7.Controls.Add(this.listBox2);
            this.panel7.Controls.Add(this.listBox1);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // btn_endSession
            // 
            resources.ApplyResources(this.btn_endSession, "btn_endSession");
            this.btn_endSession.Name = "btn_endSession";
            this.btn_endSession.UseVisualStyleBackColor = true;
            this.btn_endSession.Click += new System.EventHandler(this.btn_endSession_Click);
            // 
            // btn_start
            // 
            resources.ApplyResources(this.btn_start, "btn_start");
            this.btn_start.Name = "btn_start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click_1);
            // 
            // btn_working
            // 
            resources.ApplyResources(this.btn_working, "btn_working");
            this.btn_working.Name = "btn_working";
            this.btn_working.UseVisualStyleBackColor = true;
            this.btn_working.Click += new System.EventHandler(this.btn_working_Click);
            // 
            // lb_Device2QueueList
            // 
            this.lb_Device2QueueList.FormattingEnabled = true;
            resources.ApplyResources(this.lb_Device2QueueList, "lb_Device2QueueList");
            this.lb_Device2QueueList.Name = "lb_Device2QueueList";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            resources.ApplyResources(this.listBox5, "listBox5");
            this.listBox5.Name = "listBox5";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // rb_hands
            // 
            resources.ApplyResources(this.rb_hands, "rb_hands");
            this.rb_hands.Name = "rb_hands";
            this.rb_hands.TabStop = true;
            this.rb_hands.UseVisualStyleBackColor = true;
            // 
            // rb_auto
            // 
            resources.ApplyResources(this.rb_auto, "rb_auto");
            this.rb_auto.Name = "rb_auto";
            this.rb_auto.TabStop = true;
            this.rb_auto.UseVisualStyleBackColor = true;
            // 
            // tb_occupiedRAM
            // 
            resources.ApplyResources(this.tb_occupiedRAM, "tb_occupiedRAM");
            this.tb_occupiedRAM.Name = "tb_occupiedRAM";
            // 
            // tb_freeRAM
            // 
            resources.ApplyResources(this.tb_freeRAM, "tb_freeRAM");
            this.tb_freeRAM.Name = "tb_freeRAM";
            // 
            // tb_takts
            // 
            resources.ApplyResources(this.tb_takts, "tb_takts");
            this.tb_takts.Name = "tb_takts";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lb_Device1QueueList
            // 
            this.lb_Device1QueueList.FormattingEnabled = true;
            resources.ApplyResources(this.lb_Device1QueueList, "lb_Device1QueueList");
            this.lb_Device1QueueList.Name = "lb_Device1QueueList";
            // 
            // lb_CPUQueueList
            // 
            this.lb_CPUQueueList.FormattingEnabled = true;
            resources.ApplyResources(this.lb_CPUQueueList, "lb_CPUQueueList");
            this.lb_CPUQueueList.Name = "lb_CPUQueueList";
            this.lb_CPUQueueList.SelectedIndexChanged += new System.EventHandler(this.lb_CPUQueueList_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            resources.ApplyResources(this.listBox2, "listBox2");
            this.listBox2.Name = "listBox2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_intensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minBurst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxBurst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minAdrSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxAdrSpace)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_endSession;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_working;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ListBox lb_CPUQueueList;
        public System.Windows.Forms.NumericUpDown nud_intensity;
        public System.Windows.Forms.NumericUpDown nud_minBurst;
        public System.Windows.Forms.NumericUpDown nud_maxBurst;
        public System.Windows.Forms.ComboBox cb_sizeRAM;
        public System.Windows.Forms.NumericUpDown nud_minAdrSpace;
        public System.Windows.Forms.NumericUpDown nud_maxAdrSpace;
        public System.Windows.Forms.ListBox lb_Device2QueueList;
        public System.Windows.Forms.ListBox listBox5;
        public System.Windows.Forms.RadioButton rb_hands;
        public System.Windows.Forms.RadioButton rb_auto;
        public System.Windows.Forms.TextBox tb_occupiedRAM;
        public System.Windows.Forms.TextBox tb_freeRAM;
        public System.Windows.Forms.TextBox tb_takts;
        public System.Windows.Forms.ListBox lb_Device1QueueList;
        public System.Windows.Forms.ListBox listBox2;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer;
    }
}

