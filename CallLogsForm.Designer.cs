namespace FinalADB
{
    partial class CallLogsForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
<<<<<<< HEAD
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1284, 574);
=======
            this.textBox1.Location = new System.Drawing.Point(26, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(693, 162);
>>>>>>> 01b559577af082ecd5c259b23c559fd26b1d3468
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
<<<<<<< HEAD
            this.button1.Location = new System.Drawing.Point(535, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 76);
=======
            this.button1.Location = new System.Drawing.Point(26, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 24);
>>>>>>> 01b559577af082ecd5c259b23c559fd26b1d3468
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Call Logs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
<<<<<<< HEAD
            this.button2.Location = new System.Drawing.Point(535, 740);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 81);
=======
            this.button2.Location = new System.Drawing.Point(26, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 26);
>>>>>>> 01b559577af082ecd5c259b23c559fd26b1d3468
            this.button2.TabIndex = 2;
            this.button2.Text = "Save To DB";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CallLogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1293, 862);
=======
            this.ClientSize = new System.Drawing.Size(800, 450);
>>>>>>> 01b559577af082ecd5c259b23c559fd26b1d3468
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "CallLogsForm";
            this.Text = "CallLogsForm";
            this.Load += new System.EventHandler(this.CallLogsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}