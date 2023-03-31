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

namespace Курсовая_работа
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedCells[0].Value.ToString();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._Sales_id". При необходимости она может быть перемещена или удалена.
            this.sales_idTableAdapter.Fill(this.kursDataSet._Sales_id);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1._Sales_id". При необходимости она может быть перемещена или удалена.
            this.sales_idTableAdapter.Fill(this.kursDataSet._Sales_id);
            SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection.Open();
            string response = $"Select count FROM Products WHERE id={id}";
            SqlCommand command = new SqlCommand(response, connection);
            string countOfProducts = command.ExecuteScalar().ToString();
            labelCount.Text = countOfProducts;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
