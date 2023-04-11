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

namespace Курсовая_работа
{
    public partial class editingSales : Form
    {
        int selectedRow;
        public editingSales()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox6.Text = row.Cells[4].Value.ToString();
                textBox7.Text = row.Cells[5].Value.ToString();
                textBox9.Text = row.Cells[6].Value.ToString();
                textBox10.Text = row.Cells[7].Value.ToString();
                textBox12.Text = row.Cells[8].Value.ToString();
                textBox13.Text = row.Cells[9].Value.ToString();
                textBox15.Text = row.Cells[10].Value.ToString();
                textBox16.Text = row.Cells[11].Value.ToString();
                comboBox1.Text = row.Cells[12].Value.ToString();

            }
        }

        private void drawing4_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = "UPDATE Sales SET Id_Employees = '" + textBox2.Text + "', Data_of_Sale = '" + dateTimePicker1.Text + "', Id_Product = '" + textBox4.Text + "', Count = '" + textBox6.Text + "', Id_Products1 = '" + textBox7.Text + "', Count1 = '" + textBox9.Text + "', Id_Products2 = '" + textBox10.Text + "', Count2 = '" + textBox12.Text + "', Id_Products3 = '" + textBox13.Text + "', Count3 = '" + textBox15.Text + "', Sale_Amount = '" + textBox16.Text + "', Payment = '" + comboBox1.Text + "'WHERE Id = '" + textBox1.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
            this.salesTableAdapter.Fill(this.kursDataSet.Sales);
        }

        private void drawing2_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
                salesTableAdapter.Update(kursDataSet);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchValue = textBox18.Text.Trim();

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

        private void editingSales_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.kursDataSet.Sales);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drawing3_Click(object sender, EventArgs e)
        {
            Empl empl = new Empl();
            empl.Show();
        }

        private void drawing1_Click(object sender, EventArgs e)
        {
            Prod prod = new Prod();
            prod.Show();
        }
    }
}
