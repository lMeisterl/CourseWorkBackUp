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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсовая_работа
{
    public partial class AddDelivey : Form
    {
        public void change(DataGridView gridView)
        {
            
        }
        public AddDelivey()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = $"INSERT INTO Delivery (Id_Client, Id_Employee, Id_Sale, Date, Type, Price, Payment) VALUES ('"+textBox2.Text+"', '"+textBox3.Text+"','"+textBox1.Text+"', '"+maskedTextBox1.Text+"',  '"+textBox6.Text+"', '"+textBox7.Text+"', '"+comboBox1.Text+"')";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
