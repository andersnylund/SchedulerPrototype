namespace Prototype.Views
{
    partial class FittestChromosomeView
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
            this.shiftGridView = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift1Requrement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift2Requirement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift3Requirement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift1Assignments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift2Assignments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift3Assignments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.personGridView = new System.Windows.Forms.DataGridView();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfAssignedShifts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedShifts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.calculationSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.objectiveCostTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.generationTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.personAssignmentCostTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shiftAssignmentCostTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shiftGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shiftGridView
            // 
            this.shiftGridView.AllowUserToAddRows = false;
            this.shiftGridView.AllowUserToDeleteRows = false;
            this.shiftGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shiftGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.Shift1Requrement,
            this.Shift2Requirement,
            this.Shift3Requirement,
            this.Shift1Assignments,
            this.Shift2Assignments,
            this.Shift3Assignments});
            this.shiftGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shiftGridView.Location = new System.Drawing.Point(3, 3);
            this.shiftGridView.Name = "shiftGridView";
            this.shiftGridView.ReadOnly = true;
            this.shiftGridView.RowTemplate.Height = 33;
            this.shiftGridView.Size = new System.Drawing.Size(2029, 393);
            this.shiftGridView.TabIndex = 0;
            // 
            // Day
            // 
            this.Day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            this.Day.Width = 95;
            // 
            // Shift1Requrement
            // 
            this.Shift1Requrement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Shift1Requrement.HeaderText = "Shift 1 Requirement";
            this.Shift1Requrement.Name = "Shift1Requrement";
            this.Shift1Requrement.ReadOnly = true;
            // 
            // Shift2Requirement
            // 
            this.Shift2Requirement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Shift2Requirement.HeaderText = "Shift 2 Requirement";
            this.Shift2Requirement.Name = "Shift2Requirement";
            this.Shift2Requirement.ReadOnly = true;
            // 
            // Shift3Requirement
            // 
            this.Shift3Requirement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Shift3Requirement.HeaderText = "Shift 3 Requirement";
            this.Shift3Requirement.Name = "Shift3Requirement";
            this.Shift3Requirement.ReadOnly = true;
            // 
            // Shift1Assignments
            // 
            this.Shift1Assignments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Shift1Assignments.HeaderText = "Shift 1 Assignments";
            this.Shift1Assignments.Name = "Shift1Assignments";
            this.Shift1Assignments.ReadOnly = true;
            // 
            // Shift2Assignments
            // 
            this.Shift2Assignments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Shift2Assignments.HeaderText = "Shift 2 Assignments";
            this.Shift2Assignments.Name = "Shift2Assignments";
            this.Shift2Assignments.ReadOnly = true;
            // 
            // Shift3Assignments
            // 
            this.Shift3Assignments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Shift3Assignments.HeaderText = "Shift 3 Assignments";
            this.Shift3Assignments.Name = "Shift3Assignments";
            this.Shift3Assignments.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.shiftGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.personGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2035, 1148);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // personGridView
            // 
            this.personGridView.AllowUserToAddRows = false;
            this.personGridView.AllowUserToDeleteRows = false;
            this.personGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Person,
            this.NumberOfAssignedShifts,
            this.AssignedShifts});
            this.personGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personGridView.Location = new System.Drawing.Point(3, 402);
            this.personGridView.Name = "personGridView";
            this.personGridView.ReadOnly = true;
            this.personGridView.RowTemplate.Height = 33;
            this.personGridView.Size = new System.Drawing.Size(2029, 393);
            this.personGridView.TabIndex = 2;
            // 
            // Person
            // 
            this.Person.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Person.HeaderText = "Person";
            this.Person.Name = "Person";
            this.Person.ReadOnly = true;
            this.Person.Width = 125;
            // 
            // NumberOfAssignedShifts
            // 
            this.NumberOfAssignedShifts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NumberOfAssignedShifts.HeaderText = "Number of Assigned Shifts";
            this.NumberOfAssignedShifts.Name = "NumberOfAssignedShifts";
            this.NumberOfAssignedShifts.ReadOnly = true;
            this.NumberOfAssignedShifts.Width = 150;
            // 
            // AssignedShifts
            // 
            this.AssignedShifts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AssignedShifts.HeaderText = "Assigned Shifts";
            this.AssignedShifts.Name = "AssignedShifts";
            this.AssignedShifts.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 801);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(2029, 44);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.calculationSpeedTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.objectiveCostTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.timeTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.generationTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.personAssignmentCostTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.shiftAssignmentCostTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 851);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2029, 294);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "This solution";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(578, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "(objective)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1488, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "(Generations/second)";
            // 
            // calculationSpeedTextBox
            // 
            this.calculationSpeedTextBox.Enabled = false;
            this.calculationSpeedTextBox.Location = new System.Drawing.Point(1272, 164);
            this.calculationSpeedTextBox.Name = "calculationSpeedTextBox";
            this.calculationSpeedTextBox.Size = new System.Drawing.Size(200, 31);
            this.calculationSpeedTextBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1033, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Calculation speed";
            // 
            // objectiveCostTextBox
            // 
            this.objectiveCostTextBox.Enabled = false;
            this.objectiveCostTextBox.Location = new System.Drawing.Point(358, 161);
            this.objectiveCostTextBox.Name = "objectiveCostTextBox";
            this.objectiveCostTextBox.Size = new System.Drawing.Size(200, 31);
            this.objectiveCostTextBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Objective cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(578, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "(constraint)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "(constraint)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1488, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "(HH:mm:ss:milliseconds)";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Enabled = false;
            this.timeTextBox.Location = new System.Drawing.Point(1272, 70);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(200, 31);
            this.timeTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1033, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time to find";
            // 
            // generationTextBox
            // 
            this.generationTextBox.Enabled = false;
            this.generationTextBox.Location = new System.Drawing.Point(1272, 119);
            this.generationTextBox.Name = "generationTextBox";
            this.generationTextBox.Size = new System.Drawing.Size(200, 31);
            this.generationTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1033, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Generation";
            // 
            // personAssignmentCostTextBox
            // 
            this.personAssignmentCostTextBox.Enabled = false;
            this.personAssignmentCostTextBox.Location = new System.Drawing.Point(358, 116);
            this.personAssignmentCostTextBox.Name = "personAssignmentCostTextBox";
            this.personAssignmentCostTextBox.Size = new System.Drawing.Size(200, 31);
            this.personAssignmentCostTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Person assignment cost";
            // 
            // shiftAssignmentCostTextBox
            // 
            this.shiftAssignmentCostTextBox.Enabled = false;
            this.shiftAssignmentCostTextBox.Location = new System.Drawing.Point(358, 70);
            this.shiftAssignmentCostTextBox.Name = "shiftAssignmentCostTextBox";
            this.shiftAssignmentCostTextBox.Size = new System.Drawing.Size(200, 31);
            this.shiftAssignmentCostTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shift assignment cost";
            // 
            // FittestChromosomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2035, 1148);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FittestChromosomeView";
            this.ShowIcon = false;
            this.Text = "Best found solution";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.shiftGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView shiftGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView personGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shiftAssignmentCostTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox personAssignmentCostTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift1Requrement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift2Requirement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift3Requirement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift1Assignments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift2Assignments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift3Assignments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfAssignedShifts;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedShifts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox generationTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox objectiveCostTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox calculationSpeedTextBox;
        private System.Windows.Forms.Label label10;
    }
}