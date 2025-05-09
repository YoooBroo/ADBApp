using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalADB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }

<<<<<<< HEAD
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
=======
>>>>>>> 01b559577af082ecd5c259b23c559fd26b1d3468
    }
}
