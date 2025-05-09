namespace YourNamespace
{
    partial class ReportForm
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
<<<<<<< HEAD
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.finalADBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalADBDataSet = new FinalADB.FinalADBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalADBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalADBDataSet)).BeginInit();
=======
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.finalADBDataSet = new FinalADB.FinalADBDataSet();
            this.finalADBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalADBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalADBDataSetBindingSource)).BeginInit();
>>>>>>> 01b559577af082ecd5c259b23c559fd26b1d3468
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
<<<<<<< HEAD
=======
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
>>>>>>> 01b559577af082ecd5c259b23c559fd26b1d3468
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 38);
            this.button3.TabIndex = 3;
<<<<<<< HEAD
            this.button3.Text = "export";
=======
            this.button3.Text = "button3";
>>>>>>> 01b559577af082ecd5c259b23c559fd26b1d3468
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.finalADBDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(246, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(503, 355);
            this.dataGridView1.TabIndex = 4;
<<<<<<< HEAD
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // finalADBDataSetBindingSource
            // 
            this.finalADBDataSetBindingSource.DataSource = this.finalADBDataSet;
            this.finalADBDataSetBindingSource.Position = 0;
=======
>>>>>>> 01b559577af082ecd5c259b23c559fd26b1d3468
            // 
            // finalADBDataSet
            // 
            this.finalADBDataSet.DataSetName = "FinalADBDataSet";
            this.finalADBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
<<<<<<< HEAD
=======
            // finalADBDataSetBindingSource
            // 
            this.finalADBDataSetBindingSource.DataSource = this.finalADBDataSet;
            this.finalADBDataSetBindingSource.Position = 0;
            // 
>>>>>>> 01b559577af082ecd5c259b23c559fd26b1d3468
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
<<<<<<< HEAD
=======
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
>>>>>>> 01b559577af082ecd5c259b23c559fd26b1d3468
            this.Controls.Add(this.comboBox1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.finalADBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalADBDataSet)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.finalADBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalADBDataSetBindingSource)).EndInit();
>>>>>>> 01b559577af082ecd5c259b23c559fd26b1d3468
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
<<<<<<< HEAD
=======
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
>>>>>>> 01b559577af082ecd5c259b23c559fd26b1d3468
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource finalADBDataSetBindingSource;
        private FinalADB.FinalADBDataSet finalADBDataSet;
    }
}