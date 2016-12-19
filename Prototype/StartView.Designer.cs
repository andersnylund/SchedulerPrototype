namespace Prototype
{
    partial class StartView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreateNewTimeperiod = new System.Windows.Forms.Button();
            this.buttonOpenTimePeriod = new System.Windows.Forms.Button();
            this.buttonSaveTimePeriod = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAvailablePersons = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCurrentMaxPersonsPerShift = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCurrentTimePeriodLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShowCurrentTimePeriod = new System.Windows.Forms.Button();
            this.buttonFindBestSolution = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeLimit = new System.Windows.Forms.NumericUpDown();
            this.generationLimit = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelRunning = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateNewTimeperiod
            // 
            this.buttonCreateNewTimeperiod.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateNewTimeperiod.Name = "buttonCreateNewTimeperiod";
            this.buttonCreateNewTimeperiod.Size = new System.Drawing.Size(176, 97);
            this.buttonCreateNewTimeperiod.TabIndex = 1;
            this.buttonCreateNewTimeperiod.Text = "Create new Timeperiod";
            this.buttonCreateNewTimeperiod.UseVisualStyleBackColor = true;
            this.buttonCreateNewTimeperiod.Click += new System.EventHandler(this.buttonGenerateNewTimePeriod_Click);
            // 
            // buttonOpenTimePeriod
            // 
            this.buttonOpenTimePeriod.Location = new System.Drawing.Point(376, 12);
            this.buttonOpenTimePeriod.Name = "buttonOpenTimePeriod";
            this.buttonOpenTimePeriod.Size = new System.Drawing.Size(176, 97);
            this.buttonOpenTimePeriod.TabIndex = 3;
            this.buttonOpenTimePeriod.Text = "Open Timeperiod";
            this.buttonOpenTimePeriod.UseVisualStyleBackColor = true;
            this.buttonOpenTimePeriod.Click += new System.EventHandler(this.buttonOpenTimePeriod_Click);
            // 
            // buttonSaveTimePeriod
            // 
            this.buttonSaveTimePeriod.Location = new System.Drawing.Point(194, 12);
            this.buttonSaveTimePeriod.Name = "buttonSaveTimePeriod";
            this.buttonSaveTimePeriod.Size = new System.Drawing.Size(176, 97);
            this.buttonSaveTimePeriod.TabIndex = 2;
            this.buttonSaveTimePeriod.Text = "Save Timeperiod";
            this.buttonSaveTimePeriod.UseVisualStyleBackColor = true;
            this.buttonSaveTimePeriod.Click += new System.EventHandler(this.buttonSaveTimePeriod_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAvailablePersons);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxCurrentMaxPersonsPerShift);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCurrentTimePeriodLength);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 242);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current timeperiod";
            // 
            // textBoxAvailablePersons
            // 
            this.textBoxAvailablePersons.Enabled = false;
            this.textBoxAvailablePersons.Location = new System.Drawing.Point(601, 188);
            this.textBoxAvailablePersons.Name = "textBoxAvailablePersons";
            this.textBoxAvailablePersons.Size = new System.Drawing.Size(100, 31);
            this.textBoxAvailablePersons.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Available persons";
            // 
            // textBoxCurrentMaxPersonsPerShift
            // 
            this.textBoxCurrentMaxPersonsPerShift.Enabled = false;
            this.textBoxCurrentMaxPersonsPerShift.Location = new System.Drawing.Point(601, 122);
            this.textBoxCurrentMaxPersonsPerShift.Name = "textBoxCurrentMaxPersonsPerShift";
            this.textBoxCurrentMaxPersonsPerShift.Size = new System.Drawing.Size(100, 31);
            this.textBoxCurrentMaxPersonsPerShift.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max amount of persons per shift";
            // 
            // textBoxCurrentTimePeriodLength
            // 
            this.textBoxCurrentTimePeriodLength.Enabled = false;
            this.textBoxCurrentTimePeriodLength.Location = new System.Drawing.Point(601, 55);
            this.textBoxCurrentTimePeriodLength.Name = "textBoxCurrentTimePeriodLength";
            this.textBoxCurrentTimePeriodLength.Size = new System.Drawing.Size(100, 31);
            this.textBoxCurrentTimePeriodLength.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length in days";
            // 
            // buttonShowCurrentTimePeriod
            // 
            this.buttonShowCurrentTimePeriod.Location = new System.Drawing.Point(558, 12);
            this.buttonShowCurrentTimePeriod.Name = "buttonShowCurrentTimePeriod";
            this.buttonShowCurrentTimePeriod.Size = new System.Drawing.Size(176, 96);
            this.buttonShowCurrentTimePeriod.TabIndex = 4;
            this.buttonShowCurrentTimePeriod.Text = "Show Current Timeperiod";
            this.buttonShowCurrentTimePeriod.UseVisualStyleBackColor = true;
            this.buttonShowCurrentTimePeriod.Click += new System.EventHandler(this.buttonShowCurrentTimePeriod_Click);
            // 
            // buttonFindBestSolution
            // 
            this.buttonFindBestSolution.Location = new System.Drawing.Point(12, 363);
            this.buttonFindBestSolution.Name = "buttonFindBestSolution";
            this.buttonFindBestSolution.Size = new System.Drawing.Size(164, 101);
            this.buttonFindBestSolution.TabIndex = 8;
            this.buttonFindBestSolution.Text = "Find Best Solution";
            this.buttonFindBestSolution.UseVisualStyleBackColor = true;
            this.buttonFindBestSolution.Click += new System.EventHandler(this.buttonFindBestSolution_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time limit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Generation limit";
            // 
            // timeLimit
            // 
            this.timeLimit.Location = new System.Drawing.Point(593, 375);
            this.timeLimit.Name = "timeLimit";
            this.timeLimit.Size = new System.Drawing.Size(120, 31);
            this.timeLimit.TabIndex = 11;
            // 
            // generationLimit
            // 
            this.generationLimit.Location = new System.Drawing.Point(593, 422);
            this.generationLimit.Name = "generationLimit";
            this.generationLimit.Size = new System.Drawing.Size(120, 31);
            this.generationLimit.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "(minutes)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Limit values 0 are ignored";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(12, 470);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(163, 101);
            this.buttonStop.TabIndex = 9;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelRunning
            // 
            this.labelRunning.AutoSize = true;
            this.labelRunning.ForeColor = System.Drawing.Color.Red;
            this.labelRunning.Location = new System.Drawing.Point(280, 546);
            this.labelRunning.Name = "labelRunning";
            this.labelRunning.Size = new System.Drawing.Size(272, 25);
            this.labelRunning.TabIndex = 17;
            this.labelRunning.Text = "Searching and optimizing...";
            this.labelRunning.Visible = false;
            // 
            // StartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 589);
            this.Controls.Add(this.labelRunning);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.generationLimit);
            this.Controls.Add(this.timeLimit);
            this.Controls.Add(this.buttonOpenTimePeriod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonFindBestSolution);
            this.Controls.Add(this.buttonShowCurrentTimePeriod);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSaveTimePeriod);
            this.Controls.Add(this.buttonCreateNewTimeperiod);
            this.Name = "StartView";
            this.ShowIcon = false;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.StartView_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCreateNewTimeperiod;
        private System.Windows.Forms.Button buttonOpenTimePeriod;
        private System.Windows.Forms.Button buttonSaveTimePeriod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCurrentMaxPersonsPerShift;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCurrentTimePeriodLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShowCurrentTimePeriod;
        private System.Windows.Forms.TextBox textBoxAvailablePersons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFindBestSolution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown timeLimit;
        private System.Windows.Forms.NumericUpDown generationLimit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelRunning;
    }
}

