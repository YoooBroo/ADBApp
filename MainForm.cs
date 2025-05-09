using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourNamespace;

namespace FinalADB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactsForm contactsForm = new ContactsForm();
            contactsForm.MdiParent = this;
            contactsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessagesForm m = new MessagesForm();
            m.MdiParent = this;
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CallLogsForm m = new CallLogsForm();
            m.MdiParent = this;
            m.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeviceInfoForm m = new DeviceInfoForm();
            m.MdiParent = this;
            m.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AccountsForm m = new AccountsForm();
            m.MdiParent = this;
            m.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.MdiParent = this;
            reportForm.Show();
        }
    }
}
