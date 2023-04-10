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
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = "INSERT INTO Products (Name, Price, Type, Manufacturer, Producing_Сountry, Date_of_Manufacture, Count) VALUES (@name, @price, @type, @manufacturer, @producing_Сountry, @date_of_Manufacture, @count)";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.Parameters.AddWithValue("@name", textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@price", textBox2.Text);
            sqlCommand.Parameters.AddWithValue("@type", textBox3.Text);
            sqlCommand.Parameters.AddWithValue("@manufacturer", textBox4.Text);
            sqlCommand.Parameters.AddWithValue("@producing_Сountry", textBox5.Text);
            sqlCommand.Parameters.AddWithValue("@date_of_Manufacture", dateTimePicker1.Value);
            sqlCommand.Parameters.AddWithValue("@count", textBox7.Text);
            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
            Products sf = new Products();
            sf.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products sa = new Products();
            sa.Show();
            this.Close();
        }

        private void drawing2_Click(object sender, EventArgs e)
        {
            Products sa = new Products();
            sa.Show();
            this.Close();
        }

        private void drawing1_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = "INSERT INTO Products (Name, Price, Type, Manufacturer, Producing_Сountry, Date_of_Manufacture, Count) VALUES (@name, @price, @type, @manufacturer, @producing_Сountry, @date_of_Manufacture, @count)";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.Parameters.AddWithValue("@name", textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@price", textBox2.Text);
            sqlCommand.Parameters.AddWithValue("@type", textBox3.Text);
            sqlCommand.Parameters.AddWithValue("@manufacturer", textBox4.Text);
            sqlCommand.Parameters.AddWithValue("@producing_Сountry", textBox5.Text);
            sqlCommand.Parameters.AddWithValue("@date_of_Manufacture", dateTimePicker1.Value);
            sqlCommand.Parameters.AddWithValue("@count", textBox7.Text);
            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
            Products sf = new Products();
            sf.Show();
            this.Close();
        }
    }
}
