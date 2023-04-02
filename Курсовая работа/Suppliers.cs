using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая_работа.KursDataSetTableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсовая_работа
{
    public partial class Suppliers : Form
    {
        int selectedRow;
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.kursDataSet.Suppliers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSuppliers jg = new AddSuppliers();
            jg.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
                suppliersTableAdapter.Update(kursDataSet);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminPanel tg = new AdminPanel();
            tg.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = "UPDATE Suppliers SET First_Name = '" + textBox2.Text + "', Surname = '" + textBox3.Text + "', Middle_Name = '" + textBox4.Text + "', Telephone = '" + maskedTextBox1.Text + "', [E-mail] = '" + textBox6.Text + "', Adress = '" + textBox7.Text + "', Company = '" + textBox8.Text + "', Notes = '" + textBox9.Text + "' WHERE id = '"+textBox1.Text+"'";
            SqlCommand command = new SqlCommand(insertQuery, connection_new);
            command.ExecuteNonQuery();
            connection_new.Close();
            this.suppliersTableAdapter.Fill(this.kursDataSet.Suppliers);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                maskedTextBox1.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
                textBox7.Text = row.Cells[6].Value.ToString();
                textBox8.Text = row.Cells[7].Value.ToString();
                textBox9.Text = row.Cells[8].Value.ToString();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string searchValue = textBox5.Text.Trim();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString().Equals(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        // Highlight the matching row and scroll to it
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }
    }
}
