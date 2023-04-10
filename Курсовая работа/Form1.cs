using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Курсовая_работа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginuser = textBox1.Text;
            var passworduser = textBox2.Text;
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string querystring = $"select Id, Login, Password, is_admin from Employees where login = '{loginuser}' and password = '{passworduser}'";
            SqlCommand command = new SqlCommand(querystring, connection_new);
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                if (Convert.ToBoolean(dataTable.Rows[0].ItemArray[3]) == true)
                {
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    this.Hide();
                    MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
            }
            else MessageBox.Show("Неверный логин или пароль");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void drawing1_Click(object sender, EventArgs e)
        {
            var loginuser = textBox1.Text;
            var passworduser = textBox2.Text;
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string querystring = $"select Id, Login, Password, is_admin from Employees where login = '{loginuser}' and password = '{passworduser}'";
            SqlCommand command = new SqlCommand(querystring, connection_new);
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                if (Convert.ToBoolean(dataTable.Rows[0].ItemArray[3]) == true)
                {
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    this.Hide();
                    MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
            }
            else MessageBox.Show("Неверный логин или пароль");
        }

        private void drawing2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }
    }
}
    

