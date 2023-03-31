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
            textBox2.PasswordChar = '*';
            pictureBox2.Visible = true;
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



            /*string login1 = "admin";
            string password1 = "1111";
            string login2 = "сотр1";
            string password2 = "1234";
            string login3 = "сотр2";
            string password3 = "4321";*
            if (textBox1.Text == login1 && textBox2.Text == password1)
            {
                AdminPanel f = new AdminPanel();
                f.Show();
                Visible = false;
            }
            else if (textBox1.Text == login2 && textBox2.Text == password2)
            {
                Form2 a = new Form2();
                a.Show();
            }
            else if (textBox1.Text == login3 && textBox2.Text == password3)
            {
                Form2 v = new Form2();
                v.Show();
            }
            else MessageBox.Show(text: "Неверный логин или пароль");*/

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
    

