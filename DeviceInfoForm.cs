using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;       // For Process (running ADB)
using System.IO;                // For File.ReadAllText, File.ReadAllLines
using System.Windows.Forms;     // For Windows Forms controls like TextBox
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace FinalADB
{
    public partial class DeviceInfoForm : Form
    {
        public DeviceInfoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = "adb shell getprop";
            string outputFile = "device.txt";

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {command} > {outputFile}",
                    RedirectStandardOutput = false,
                    UseShellExecute = true,
                    CreateNoWindow = true
                }
            };
            process.Start();
            process.WaitForExit();

            if (File.Exists(outputFile))
            {
                textBox1.Text = File.ReadAllText(outputFile);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("device.txt");

            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Spark\\OneDrive\\Documents\\FinalADB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();
                foreach (var line in lines)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO DeviceInfoTable (RawData) VALUES (@data)", con);
                    cmd.Parameters.AddWithValue("@data", line);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Saved to database");
            }
        }

        private void DeviceInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
