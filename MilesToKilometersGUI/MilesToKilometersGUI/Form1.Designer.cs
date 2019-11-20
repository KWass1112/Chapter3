namespace MilesToKilometersGUI
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
            this.btn_convert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToKilos = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(159, 164);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(120, 43);
            this.btn_convert.TabIndex = 0;
            this.btn_convert.Text = "Convert to kilos";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Miles:";
            // 
            // lblToKilos
            // 
            this.lblToKilos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblToKilos.Location = new System.Drawing.Point(163, 248);
            this.lblToKilos.Name = "lblToKilos";
            this.lblToKilos.Size = new System.Drawing.Size(159, 28);
            this.lblToKilos.TabIndex = 2;
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(222, 61);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 3;
            this.txtMiles.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 446);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.lblToKilos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_convert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToKilos;
        private System.Windows.Forms.TextBox txtMiles;
    }
}

