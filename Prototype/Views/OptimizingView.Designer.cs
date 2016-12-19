namespace Prototype.Optimization
{
    partial class OptimizingView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shiftCost = new System.Windows.Forms.TextBox();
            this.personCost = new System.Windows.Forms.TextBox();
            this.objectiveCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.generation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shift assigment cost (constraint)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Person assigment cost (constraint)";
            // 
            // shiftCost
            // 
            this.shiftCost.Enabled = false;
            this.shiftCost.Location = new System.Drawing.Point(199, 19);
            this.shiftCost.Name = "shiftCost";
            this.shiftCost.Size = new System.Drawing.Size(100, 20);
            this.shiftCost.TabIndex = 2;
            // 
            // personCost
            // 
            this.personCost.Enabled = false;
            this.personCost.Location = new System.Drawing.Point(199, 55);
            this.personCost.Name = "personCost";
            this.personCost.Size = new System.Drawing.Size(100, 20);
            this.personCost.TabIndex = 3;
            // 
            // objectiveCost
            // 
            this.objectiveCost.Enabled = false;
            this.objectiveCost.Location = new System.Drawing.Point(199, 91);
            this.objectiveCost.Name = "objectiveCost";
            this.objectiveCost.Size = new System.Drawing.Size(100, 20);
            this.objectiveCost.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Objective cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Generation";
            // 
            // generation
            // 
            this.generation.Enabled = false;
            this.generation.Location = new System.Drawing.Point(199, 124);
            this.generation.Name = "generation";
            this.generation.Size = new System.Drawing.Size(100, 20);
            this.generation.TabIndex = 7;
            // 
            // OptimizingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 156);
            this.Controls.Add(this.generation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.objectiveCost);
            this.Controls.Add(this.personCost);
            this.Controls.Add(this.shiftCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OptimizingView";
            this.Text = "Optimizing...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox shiftCost;
        private System.Windows.Forms.TextBox personCost;
        private System.Windows.Forms.TextBox objectiveCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox generation;
    }
}