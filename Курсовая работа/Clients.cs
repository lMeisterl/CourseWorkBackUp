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
    public partial class Clients : Form
    {
        int selectedRow;
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.kursDataSet.Clients);
            ToolTip d = new ToolTip();
            d.SetToolTip(drawing2, "Удалить");
            ToolTip v = new ToolTip();
            v.SetToolTip(drawing1, "Добавить");
            ToolTip f = new ToolTip();
            f.SetToolTip(button5, "Закрыть");
            ToolTip r = new ToolTip();
            r.SetToolTip(button7, "Обновить");
            ToolTip back = new ToolTip();
            back.SetToolTip(button4, "Назад");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Clients", connection_new);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0];

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Surname LIKE '%{textBox1.Text}%'";
            connection_new.Close();
        }

        private void drawing4_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = "UPDATE Clients SET First_Name = '" + textBox3.Text + "', Surname = '" + textBox4.Text + "', Middle_Name = '" + textBox5.Text + "', Gender = '" + comboBox1.Text + "', Telephone = '" + maskedTextBox1.Text + "',[E-mail] = '"+textBox6.Text+"',  Adress = '"+textBox7.Text+"', Status = '"+textBox8.Text+"' WHERE Id = '" + textBox2.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
            MessageBox.Show("Успешно изменено!");
            this.clientsTableAdapter.Fill(this.kursDataSet.Clients);
        }

        private void drawing2_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
                clientsTableAdapter.Update(kursDataSet);
            }
            MessageBox.Show("Успешно удалено!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.clientsTableAdapter.Fill(this.kursDataSet.Clients);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox2.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
                textBox4.Text = row.Cells[2].Value.ToString();
                textBox5.Text = row.Cells[3].Value.ToString();
                comboBox1.Text = row.Cells[4].Value.ToString();
                maskedTextBox1.Text = row.Cells[5].Value.ToString();
                textBox6.Text = row.Cells[6].Value.ToString();
                textBox7.Text = row.Cells[7].Value.ToString();
                textBox8.Text = row.Cells[8].Value.ToString();

            }
        }

        private void drawing1_Click(object sender, EventArgs e)
        {
            AddClients addClients = new AddClients();
            addClients.ShowDialog();
        }
    }
}
