using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YourNamespace
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Contacts", "Messages", "CallLogs", "DeviceInfo", "Accounts" });
        }

        // Load data from database
        private void button1_Click(object sender, EventArgs e)
        {
            string tableName = "";

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Contacts": tableName = "ContactsTable"; break;
                case "Messages": tableName = "MessagesTable"; break;
                case "CallLogs": tableName = "CallLogsTable"; break;
                case "DeviceInfo": tableName = "DeviceInfoTable"; break;
                case "Accounts": tableName = "AccountsTable"; break;
                default: MessageBox.Show("Invalid selection."); return;
            }

            using (SqlConnection conn = new SqlConnection("Your_Connection_String_Here"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + tableName, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        // Export to CSV
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = "Report.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    // Header
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        sw.Write(dataGridView1.Columns[i].HeaderText);
                        if (i < dataGridView1.Columns.Count - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();

                    // Rows
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                sw.Write(row.Cells[i].Value?.ToString());
                                if (i < row.Cells.Count - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }
                }

                MessageBox.Show("CSV exported successfully.");
            }
        }

        // Export to PDF
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = "Report.pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                doc.Open();

                PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);

                // Headers
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    pdfTable.AddCell(new Phrase(column.HeaderText));
                }

                // Rows
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(new Phrase(cell.Value?.ToString()));
                        }
                    }
                }

                doc.Add(pdfTable);
                doc.Close();

                MessageBox.Show("PDF exported successfully.");
            }
        }
<<<<<<< HEAD

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
=======
>>>>>>> 01b559577af082ecd5c259b23c559fd26b1d3468
    }
}
