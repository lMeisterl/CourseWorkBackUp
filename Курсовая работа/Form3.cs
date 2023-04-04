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
using System.Xml.Linq;

namespace Курсовая_работа
{
    public partial class Form3 : Form
    {
        int selectedRow;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.kursDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.kursDataSet.Employees);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployee sa = new AddEmployee();
            sa.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
                employeesTableAdapter.Update(kursDataSet);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminPanel g = new AdminPanel();
            g.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* // Worker => Edit...
            EditProducts f = new EditProducts();
            int index;
            string First_Name, Surname, Middle_Name, Telephone, Passport, Gender, Date_of_Birth, Job_Title, Education;
            int id;

            if (dataGridView1.RowCount <= 1) return;

            // получить позицию выделенной строки в dataGridView1
            index = dataGridView1.CurrentRow.Index;

            if (index == dataGridView1.RowCount - 1) return; //

            // получить данные строки
            id = (int)dataGridView1.Rows[index].Cells[0].Value;
            First_Name = (string)dataGridView1.Rows[index].Cells[1].Value;
            Surname = (string)dataGridView1.Rows[index].Cells[2].Value;
            Middle_Name = (string)dataGridView1.Rows[index].Cells[3].Value;
            Telephone = (string)dataGridView1.Rows[index].Cells[4].Value;
            Passport = (string)dataGridView1.Rows[index].Cells[5].Value;
            Gender = (string)dataGridView1.Rows[index].Cells[6].Value;
            Date_of_Birth = (string)dataGridView1.Rows[index].Cells[7].Value;
            Job_Title = (string)dataGridView1.Rows[index].Cells[8].Value;
            Education = (string)dataGridView1.Rows[index].Cells[9].Value;

            // заполнить поля формы f

            if (f.ShowDialog() == DialogResult.OK) // вызвать форму FormEditWorker
            {

                // получить новые (измененные) значения из формы
                SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
                string insertQuery = "INSERT INTO Employees (First_Name, Surname, Middle_Name, Telephone, Passport, Gender, Date_of_Birth, Job_Title, Education) VALUES (@name, @surname, @MidleName, @Telephone, @Passport, @Gender, @DataBirth, @Post, @Education)";
                SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
                sqlCommand.Parameters.AddWithValue("@name", f.textBox1.Text);
                sqlCommand.Parameters.AddWithValue("@surname", f.textBox2.Text);
                sqlCommand.Parameters.AddWithValue("@MidleName", f.textBox3.Text);
                sqlCommand.Parameters.AddWithValue("@Telephone", f.textBox4.Text);
                sqlCommand.Parameters.AddWithValue("@Passport", f.textBox5.Text);
                sqlCommand.Parameters.AddWithValue("@Gender", f.textBox6.Text);
                sqlCommand.Parameters.AddWithValue("@DataBirth", f.textBox7.Text);
                sqlCommand.Parameters.AddWithValue("@Post", f.textBox8.Text);
                sqlCommand.Parameters.AddWithValue("@Education", f.textBox9.Text);
                sqlCommand.ExecuteNonQuery();
                connection_new.Close();
                // сделать изменения в адаптере
                this.employeesTableAdapter.Fill(this.kursDataSet.Employees);
            }*/
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            /*DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            row.Cells[1].Value = textBox3.Text;
            row.Cells[2].Value = textBox4.Text;
            row.Cells[3].Value = textBox5.Text;
            row.Cells[4].Value = maskedTextBox1.Text;
            row.Cells[5].Value = textBox7.Text;
            row.Cells[6].Value = textBox8.Text;
            row.Cells[7].Value = dateTimePicker1.Text;
            row.Cells[8].Value = textBox10.Text;
            row.Cells[9].Value = textBox11.Text;*/
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = "UPDATE Employees SET First_Name = '"+textBox3.Text+"', Surname = '"+textBox4.Text+"', Middle_Name = '"+textBox5.Text+"', Telephone = '"+maskedTextBox1.Text+"', Passport = '"+maskedTextBox2.Text+"', Gender = '"+comboBox1.Text+"', Date_of_Birth = '"+dateTimePicker1.Value+"', Job_Title = '"+textBox10.Text+"', Education = '"+textBox11.Text+"'WHERE Id = '"+textBox2.Text+"'";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
            this.employeesTableAdapter.Fill(this.kursDataSet.Employees);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddLogin addLogin = new AddLogin();
            addLogin.Show();
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
                maskedTextBox1.Text = row.Cells[4].Value.ToString();
                maskedTextBox2.Text = row.Cells[5].Value.ToString();
                comboBox1.Text = row.Cells[6].Value.ToString();
                dateTimePicker1.Text = row.Cells[7].Value.ToString();
                textBox10.Text = row.Cells[8].Value.ToString();
                textBox11.Text = row.Cells[9].Value.ToString();
                textBox12.Text = row.Cells[10].Value.ToString();

            }
        }
        private void Search(DataGridView dgw)
        {
            /*SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");

            string searchString = $"select * from Employees where concat (Id, First_Name, Surname, Middle_Name, Passport, Gender, Job_Title, Education, ) like '%" + textBox1.Text + "%'";
            SqlCommand com = new SqlCommand(searchString, connection_new);

            connection_new.Open();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                //ReadSingleRow(dgw, read);
            }
            read.Close();
            connection_new.Close();*/
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.Trim();

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
