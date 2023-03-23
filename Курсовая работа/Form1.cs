using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login1 = "admin";
            string password1 = "1111";
            string login2 = "сотр1";
            string password2 = "1234";
            string login3 = "сотр2";
            string password3 = "4321";
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
            else MessageBox.Show(text: "Неверный логин или пароль");
            
        }
    }
}
