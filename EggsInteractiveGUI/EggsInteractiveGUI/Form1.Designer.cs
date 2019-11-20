namespace EggsInteractiveGUI
{
    partial class Form1
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
            this.txtEntry1 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lable1 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.txtEntry5 = new System.Windows.Forms.TextBox();
            this.txtEntry4 = new System.Windows.Forms.TextBox();
            this.txtEntry2 = new System.Windows.Forms.TextBox();
            this.txtEntry3 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEntry1
            // 
            this.txtEntry1.Location = new System.Drawing.Point(42, 78);
            this.txtEntry1.Name = "txtEntry1";
            this.txtEntry1.Size = new System.Drawing.Size(49, 20);
            this.txtEntry1.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(163, 148);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 45);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Click to calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(89, 23);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(226, 13);
            this.lable1.TabIndex = 6;
            this.lable1.Text = "Enter number of eggs layed by each chickens:";
            // 
            // txtEntry5
            // 
            this.txtEntry5.Location = new System.Drawing.Point(317, 78);
            this.txtEntry5.Name = "txtEntry5";
            this.txtEntry5.Size = new System.Drawing.Size(49, 20);
            this.txtEntry5.TabIndex = 7;
            // 
            // txtEntry4
            // 
            this.txtEntry4.Location = new System.Drawing.Point(247, 78);
            this.txtEntry4.Name = "txtEntry4";
            this.txtEntry4.Size = new System.Drawing.Size(49, 20);
            this.txtEntry4.TabIndex = 8;
            // 
            // txtEntry2
            // 
            this.txtEntry2.Location = new System.Drawing.Point(110, 78);
            this.txtEntry2.Name = "txtEntry2";
            this.txtEntry2.Size = new System.Drawing.Size(49, 20);
            this.txtEntry2.TabIndex = 9;
            // 
            // txtEntry3
            // 
            this.txtEntry3.Location = new System.Drawing.Point(177, 78);
            this.txtEntry3.Name = "txtEntry3";
            this.txtEntry3.Size = new System.Drawing.Size(49, 20);
            this.txtEntry3.TabIndex = 10;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(92, 240);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(223, 27);
            this.lblResult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 295);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtEntry3);
            this.Controls.Add(this.txtEntry2);
            this.Controls.Add(this.txtEntry4);
            this.Controls.Add(this.txtEntry5);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtEntry1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntry1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lable1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox txtEntry5;
        private System.Windows.Forms.TextBox txtEntry4;
        private System.Windows.Forms.TextBox txtEntry2;
        private System.Windows.Forms.TextBox txtEntry3;
        private System.Windows.Forms.Label lblResult;
    }
}

