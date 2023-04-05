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
    public partial class AddOrders : Form
    {
        int selectedRow;
        public AddOrders()
        {
            InitializeComponent();
        }

        private void AddOrders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
            this.suppliersTableAdapter.Fill(this.kursDataSet.Suppliers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.kursDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.kursDataSet.Employees);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = $"INSERT INTO PurchaseOrders (Id_Provider, Id_Product, Id_Employee, Count, Cost, Delivery_Date, Status) VALUES ('" + textSupl.Text + "','" + textProd.Text + "', '" + textEmp.Text + "',  '" + textCount.Text + "', '" + textPrice.Text + "', '" + textDate.Text + "', '"+textStatus+"')";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.ExecuteNonQuery();
            Int32 countProduct = getCountProduct(Convert.ToInt32(textProd.Text));
            Int32 newCountProduct = countProduct + Convert.ToInt32(textCount.Text);
            setCountproduct(newCountProduct, Convert.ToInt32(textProd.Text));
            MessageBox.Show("Доставка успешно добавлена!");
        }
        private int getCountProduct(Int32 Id)
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection.Open();
            string query = "SELECT Count FROM Products WHERE Id = @id";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@Id", Id);
            Int32 resultCount = Convert.ToInt32(sqlCommand.ExecuteScalar());
            
            return resultCount;
        }
        private void setCountproduct(Int32 count, Int32 Id) 
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection.Open();
            string query = "UPDATE Products SET Count = @count WHERE Id = @Id";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@Id", Id);
            sqlCommand.Parameters.AddWithValue("@count", count);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textEmp.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[selectedRow];

                textSupl.Text = row.Cells[7].Value.ToString();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];

                textProd.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
