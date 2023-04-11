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
    public partial class AddSuppliers : Form
    {
        public AddSuppliers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = "INSERT INTO Suppliers (First_Name, Surname, Middle_Name, Telephone, [E-mail], Adress, Company, Notes) VALUES ('"+textBox1.Text+"', '"+ textBox2.Text+"', '"+textBox3.Text+"', '"+maskedTextBox1.Text+"','"+textBox5.Text +"' , '"+textBox6.Text+"', '"+textBox7.Text+"', '"+textBox8.Text+"')";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            
            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
            Suppliers sf = new Suppliers();
            sf.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Suppliers ht = new Suppliers();
            ht.Show();
            this.Close();
        }

        private void drawing2_Click(object sender, EventArgs e)
        {
            Suppliers ht = new Suppliers();
            ht.Show();
            this.Close();
        }

        private void drawing1_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = "INSERT INTO Suppliers (First_Name, Surname, Middle_Name, Telephone, [E-mail], Adress, Company, Notes) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + maskedTextBox1.Text + "','" + textBox5.Text + "' , '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "')";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);

            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
            Suppliers sf = new Suppliers();
            sf.Show();
            this.Close();
        }

        private void AddSuppliers_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}