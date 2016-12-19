namespace Prototype.Views
{
    partial class NewTimePeriodView
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
            this.labelMaxAmount = new System.Windows.Forms.Label();
            this.labelLengthInDays = new System.Windows.Forms.Label();
            this.timePeriodLength = new System.Windows.Forms.NumericUpDown();
            this.personsPerShiftMax = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerateRandom = new System.Windows.Forms.Button();
            this.createTimePerioddataGridView = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createRandomCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonCreateByUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timePeriodLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsPerShiftMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createTimePerioddataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMaxAmount
            // 
            this.labelMaxAmount.AutoSize = true;
            this.labelMaxAmount.Location = new System.Drawing.Point(276, 85);
            this.labelMaxAmount.Name = "labelMaxAmount";
            this.labelMaxAmount.Size = new System.Drawing.Size(324, 25);
            this.labelMaxAmount.TabIndex = 6;
            this.labelMaxAmount.Text = "Max Amount of Persons per shift";
            // 
            // labelLengthInDays
            // 
            this.labelLengthInDays.AutoSize = true;
            this.labelLengthInDays.Location = new System.Drawing.Point(276, 37);
            this.labelLengthInDays.Name = "labelLengthInDays";
            this.labelLengthInDays.Size = new System.Drawing.Size(153, 25);
            this.labelLengthInDays.TabIndex = 4;
            this.labelLengthInDays.Text = "Length in days";
            // 
            // timePeriodLength
            // 
            this.timePeriodLength.Location = new System.Drawing.Point(634, 35);
            this.timePeriodLength.Name = "timePeriodLength";
            this.timePeriodLength.Size = new System.Drawing.Size(120, 31);
            this.timePeriodLength.TabIndex = 5;
            // 
            // personsPerShiftMax
            // 
            this.personsPerShiftMax.Location = new System.Drawing.Point(634, 83);
            this.personsPerShiftMax.Name = "personsPerShiftMax";
            this.personsPerShiftMax.Size = new System.Drawing.Size(120, 31);
            this.personsPerShiftMax.TabIndex = 7;
            // 
            // buttonGenerateRandom
            // 
            this.buttonGenerateRandom.Location = new System.Drawing.Point(787, 37);
            this.buttonGenerateRandom.Name = "buttonGenerateRandom";
            this.buttonGenerateRandom.Size = new System.Drawing.Size(137, 77);
            this.buttonGenerateRandom.TabIndex = 8;
            this.buttonGenerateRandom.Text = "Generate Random";
            this.buttonGenerateRandom.UseVisualStyleBackColor = true;
            this.buttonGenerateRandom.Click += new System.EventHandler(this.buttonGenerateRandom_Click);
            // 
            // createTimePerioddataGridView
            // 
            this.createTimePerioddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.createTimePerioddataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.Shift1,
            this.Shift2,
            this.Shift3});
            this.createTimePerioddataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.createTimePerioddataGridView.Location = new System.Drawing.Point(0, 217);
            this.createTimePerioddataGridView.Name = "createTimePerioddataGridView";
            this.createTimePerioddataGridView.RowTemplate.Height = 33;
            this.createTimePerioddataGridView.Size = new System.Drawing.Size(2048, 777);
            this.createTimePerioddataGridView.TabIndex = 9;
            this.createTimePerioddataGridView.Visible = false;
            this.createTimePerioddataGridView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.createTimePerioddataGridView_CellLeave);
            this.createTimePerioddataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.createTimePerioddataGridView_RowsAdded);
            // 
            // Day
            // 
            this.Day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // Shift1
            // 
            this.Shift1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Shift1.HeaderText = "Shift 1";
            this.Shift1.Name = "Shift1";
            // 
            // Shift2
            // 
            this.Shift2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Shift2.HeaderText = "Shift 2";
            this.Shift2.Name = "Shift2";
            // 
            // Shift3
            // 
            this.Shift3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Shift3.HeaderText = "Shift 3";
            this.Shift3.Name = "Shift3";
            // 
            // createRandomCheckBox
            // 
            this.createRandomCheckBox.AutoSize = true;
            this.createRandomCheckBox.Checked = true;
            this.createRandomCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.createRandomCheckBox.Location = new System.Drawing.Point(46, 65);
            this.createRandomCheckBox.Name = "createRandomCheckBox";
            this.createRandomCheckBox.Size = new System.Drawing.Size(194, 29);
            this.createRandomCheckBox.TabIndex = 10;
            this.createRandomCheckBox.Text = "Create Random";
            this.createRandomCheckBox.UseVisualStyleBackColor = true;
            this.createRandomCheckBox.CheckedChanged += new System.EventHandler(this.createRandomCheckBox_CheckedChanged);
            // 
            // buttonCreateByUser
            // 
            this.buttonCreateByUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateByUser.Location = new System.Drawing.Point(943, 37);
            this.buttonCreateByUser.Name = "buttonCreateByUser";
            this.buttonCreateByUser.Size = new System.Drawing.Size(138, 77);
            this.buttonCreateByUser.TabIndex = 11;
            this.buttonCreateByUser.Text = "Create";
            this.buttonCreateByUser.UseVisualStyleBackColor = true;
            this.buttonCreateByUser.Visible = false;
            this.buttonCreateByUser.Click += new System.EventHandler(this.buttonCreateByUser_Click);
            // 
            // NewTimePeriodView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2048, 994);
            this.Controls.Add(this.buttonCreateByUser);
            this.Controls.Add(this.createRandomCheckBox);
            this.Controls.Add(this.createTimePerioddataGridView);
            this.Controls.Add(this.buttonGenerateRandom);
            this.Controls.Add(this.personsPerShiftMax);
            this.Controls.Add(this.labelMaxAmount);
            this.Controls.Add(this.timePeriodLength);
            this.Controls.Add(this.labelLengthInDays);
            this.Name = "NewTimePeriodView";
            this.ShowIcon = false;
            this.Text = "New Timeperiod";
            ((System.ComponentModel.ISupportInitialize)(this.timePeriodLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsPerShiftMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createTimePerioddataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMaxAmount;
        private System.Windows.Forms.Label labelLengthInDays;
        private System.Windows.Forms.NumericUpDown timePeriodLength;
        private System.Windows.Forms.NumericUpDown personsPerShiftMax;
        private System.Windows.Forms.Button buttonGenerateRandom;
        private System.Windows.Forms.DataGridView createTimePerioddataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift3;
        private System.Windows.Forms.CheckBox createRandomCheckBox;
        private System.Windows.Forms.Button buttonCreateByUser;
    }
}