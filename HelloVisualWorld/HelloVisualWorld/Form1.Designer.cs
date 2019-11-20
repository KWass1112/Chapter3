namespace HelloVisualWorld
{
    partial class HelloVisualWorld
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
            this.btn_result = new System.Windows.Forms.Button();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.btn_goodbye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(242, 198);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(105, 47);
            this.btn_result.TabIndex = 0;
            this.btn_result.Text = "Click Me!!!!!";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(254, 143);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(93, 13);
            this.HelloLabel.TabIndex = 1;
            this.HelloLabel.Text = "Hello Visual World";
            // 
            // btn_goodbye
            // 
            this.btn_goodbye.Location = new System.Drawing.Point(257, 271);
            this.btn_goodbye.Name = "btn_goodbye";
            this.btn_goodbye.Size = new System.Drawing.Size(75, 23);
            this.btn_goodbye.TabIndex = 2;
            this.btn_goodbye.Text = "Goodbye";
            this.btn_goodbye.UseVisualStyleBackColor = true;
            this.btn_goodbye.Click += new System.EventHandler(this.btn_goodbye_Click);
            // 
            // HelloVisualWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 403);
            this.Controls.Add(this.btn_goodbye);
            this.Controls.Add(this.HelloLabel);
            this.Controls.Add(this.btn_result);
            this.Name = "HelloVisualWorld";
            this.Text = "Hello Visual World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button btn_goodbye;
    }
}

