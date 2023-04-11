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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.kursDataSet.Delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._Delivery_Id". При необходимости она может быть перемещена или удалена.
            this.delivery_IdTableAdapter.Fill(this.kursDataSet._Delivery_Id);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.kursDataSet.Delivery);

            ToolTip d = new ToolTip();
            d.SetToolTip(drawing2, "Удалить");
            ToolTip f = new ToolTip();
            f.SetToolTip(button9, "Закрыть");
            ToolTip r = new ToolTip();
            r.SetToolTip(button7, "Обновить");
            ToolTip back = new ToolTip();
            back.SetToolTip(button8, "Назад");
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
            string insertQuery = "UPDATE Employees SET Id_Client = '" + textBox2.Text + "', Id_Employee = '" + textBox3.Text + "', Id_Sale = '" + textBox9.Text + "', Date = '" +dateTimePicker1.Value+ "',Adress = '"+textBox5.Text+"' Type = '" + textBox6.Text + "' WHERE id = '"+textBox1.Text+"'";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
            MessageBox.Show("Успешно изменено!");
            this.delivery_IdTableAdapter.Fill(this.kursDataSet._Delivery_Id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
                deliveryTableAdapter.Update(kursDataSet);
            }
            MessageBox.Show("Успешно удалено!");
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
                textBox6.Text = row.Cells[4].Value.ToString();
                textBox5.Text = row.Cells[5].Value.ToString();
                dateTimePicker1.Text = row.Cells[6].Value.ToString();

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

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.delivery_IdTableAdapter.Fill(this.kursDataSet._Delivery_Id);
        }

        private void drawing2_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
                deliveryTableAdapter.Update(kursDataSet);
            }
            MessageBox.Show("Успешно удалено!");
        }

        private void drawing3_Click(object sender, EventArgs e)
        {
            AddDelivey addDelivey = new AddDelivey();
            addDelivey.ShowDialog();
            addDelivey.change(dataGridView1);
        }

        private void drawing4_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = "UPDATE Employees SET Id_Client = '" + textBox2.Text + "', Id_Employee = '" + textBox3.Text + "', Id_Sale = '" + textBox9.Text + "', Date = '" + dateTimePicker1.Text + "',Adress = '" + textBox5.Text + "' Type = '" + textBox6.Text + "' WHERE id = '" + textBox1.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
            MessageBox.Show("Успешно изменено!");
            this.delivery_IdTableAdapter.Fill(this.kursDataSet._Delivery_Id);
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
