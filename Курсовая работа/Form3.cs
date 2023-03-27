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
            EditProducts hf = new EditProducts();
        }
    }
}
