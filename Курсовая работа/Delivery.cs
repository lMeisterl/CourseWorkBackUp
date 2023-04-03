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
    public partial class Delivery : Form
    {
        int selectedRow;
        public Delivery()
        {
            InitializeComponent();
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._Delivery_Id". При необходимости она может быть перемещена или удалена.
            this.delivery_IdTableAdapter.Fill(this.kursDataSet._Delivery_Id);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._Delivery_Id". При необходимости она может быть перемещена или удалена.
            this.delivery_IdTableAdapter.Fill(this.kursDataSet._Delivery_Id);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDelivey addDelivey = new AddDelivey();
            addDelivey.Show();
            addDelivey.change(dataGridView1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = "UPDATE Employees SET Id_Client = '" + textBox2.Text + "', Id_Employee = '" + textBox3.Text + "', Id_Sale = '" + textBox9.Text + "', Date = '" + textBox4.Text + "',Adress = '"+textBox5.Text+"' Type = '" + textBox6.Text + "', Price = '" + textBox7.Text + "', Payment = '"+comboBox1.Text+"' WHERE id = '"+textBox1.Text+"'";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
            this.delivery_IdTableAdapter.Fill(this.kursDataSet._Delivery_Id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
                //delivery_IdTableAdapter.Update(kursDataSet);
            }
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
                textBox9.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                textBox5.Text = row.Cells[5].Value.ToString();
                textBox6.Text = row.Cells[6].Value.ToString();
                textBox7.Text = row.Cells[7].Value.ToString();
                comboBox1.Text = row.Cells[8].Value.ToString();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string searchValue = textBox8.Text.Trim();

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

        private void button6_Click(object sender, EventArgs e)
        {
            this.delivery_IdTableAdapter.Fill(this.kursDataSet._Delivery_Id);
        }
    }
}
