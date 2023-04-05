using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class AddSales : Form
    {
        int selectedRow;
        public AddSales()
        {
            InitializeComponent();
        }

        private void AddSales_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.kursDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.kursDataSet.Products);

            Load_Product1();
            Load_Product2();
            Load_Product3();
            Load_Product4();

        }
        private void Load_Product1()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True"))
            {
                string query = "SELECT Name, Price FROM Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                productComboBox1.DisplayMember = "Name";
                productComboBox1.ValueMember = "Name";
                productComboBox1.DataSource = dataTable;

                // Set the price and quantity labels for the selected product
                if (productComboBox1.SelectedValue != null)
                {
                    DataRowView row = productComboBox1.SelectedItem as DataRowView;
                    priceLabel1.Text = row["Price"].ToString();
                    /*quantityLabel.Text = row["Count"].ToString();*/
                }
                // Set the price and quantity labels for the selected product
                productComboBox1.SelectedIndexChanged += new EventHandler(productComboBox1_SelectedIndexChanged);
                productComboBox1_SelectedIndexChanged(null, null);
            }
        }
        private void productComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productComboBox1.SelectedValue != null)
            {
                DataRowView row = productComboBox1.SelectedItem as DataRowView;
                priceLabel1.Text = row["Price"].ToString();
                /*quantityLabel.Text = row["Count"].ToString();*/
            }
        }
        private void Load_Product2()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True"))
            {
                string query = "SELECT Name, Price FROM Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                productComboBox2.DisplayMember = "Name";
                productComboBox2.ValueMember = "Name";
                productComboBox2.DataSource = dataTable;

                // Set the price and quantity labels for the selected product
                if (productComboBox2.SelectedValue != null)
                {
                    DataRowView row = productComboBox1.SelectedItem as DataRowView;
                    priceLabel2.Text = row["Price"].ToString();
                    /*quantityLabel.Text = row["Count"].ToString();*/
                }
                // Set the price and quantity labels for the selected product
                productComboBox2.SelectedIndexChanged += new EventHandler(productComboBox2_SelectedIndexChanged);
                productComboBox2_SelectedIndexChanged(null, null);
            }
        }
        private void productComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productComboBox2.SelectedValue != null)
            {
                DataRowView row = productComboBox2.SelectedItem as DataRowView;
                priceLabel2.Text = row["Price"].ToString();
                /*quantityLabel.Text = row["Count"].ToString();*/
            }
        }
        private void Load_Product3()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True"))
            {
                string query = "SELECT Name, Price FROM Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                productComboBox3.DisplayMember = "Name";
                productComboBox3.ValueMember = "Name";
                productComboBox3.DataSource = dataTable;

                // Set the price and quantity labels for the selected product
                if (productComboBox3.SelectedValue != null)
                {
                    DataRowView row = productComboBox3.SelectedItem as DataRowView;
                    priceLabel1.Text = row["Price"].ToString();
                    /*quantityLabel.Text = row["Count"].ToString();*/
                }
                // Set the price and quantity labels for the selected product
                productComboBox3.SelectedIndexChanged += new EventHandler(productComboBox3_SelectedIndexChanged);
                productComboBox3_SelectedIndexChanged(null, null);
            }
        }
        private void productComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productComboBox3.SelectedValue != null)
            {
                DataRowView row = productComboBox3.SelectedItem as DataRowView;
                priceLabel3.Text = row["Price"].ToString();
                /*quantityLabel.Text = row["Count"].ToString();*/
            }
        }
        private void Load_Product4()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True"))
            {
                string query = "SELECT Name, Price FROM Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                productComboBox4.DisplayMember = "Name";
                productComboBox4.ValueMember = "Name";
                productComboBox4.DataSource = dataTable;

                // Set the price and quantity labels for the selected product
                if (productComboBox4.SelectedValue != null)
                {
                    DataRowView row = productComboBox4.SelectedItem as DataRowView;
                    priceLabel4.Text = row["Price"].ToString();
                    /*quantityLabel.Text = row["Count"].ToString();*/
                }
                // Set the price and quantity labels for the selected product
                productComboBox4.SelectedIndexChanged += new EventHandler(productComboBox4_SelectedIndexChanged);
                productComboBox4_SelectedIndexChanged(null, null);
            }
        }
        private void productComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productComboBox4.SelectedValue != null)
            {
                DataRowView row = productComboBox4.SelectedItem as DataRowView;
                priceLabel4.Text = row["Price"].ToString();
                /*quantityLabel.Text = row["Count"].ToString();*/
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = $"INSERT INTO Sales (Id_Employees, Data_of_Sale, Id_Product, Count, Id_Products1, Count1, Id_Products2, Count2, Id_Products3, Count3, Sale_Amount, Payment) VALUES ('" + textBox2.Text + "','" + dateTimePicker1.Value+ "', '" + productComboBox1.Text + "',  '" + textCount1.Text + "', '" + productComboBox2.Text + "', '" + textCount2.Text + "', '" + productComboBox3.Text+ "', '"+textCount3.Text+"', '"+productComboBox4.Text+"', '"+textCount4.Text+"', '"+textFinishCost.Text+"', '"+textBox17.Text+"')";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.ExecuteNonQuery();
            Int32 countProduct1 = getCountProduct(Convert.ToInt32(productComboBox1.Text));
            Int32 countProduct2 = getCountProduct(Convert.ToInt32(productComboBox2.Text));
            Int32 countProduct3 = getCountProduct(Convert.ToInt32(productComboBox3.Text));
            Int32 countProduct4 = getCountProduct(Convert.ToInt32(productComboBox4.Text));
            Int32 newCountProduct = countProduct1 - Convert.ToInt32(textCount1.Text);
            setCountproduct(newCountProduct, Convert.ToInt32(productComboBox1.Text));
            MessageBox.Show("Доставка успешно добавлена!");
        }
        private int getCountProduct(Int32 Id)
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection.Open();
            string query = "SELECT Price FROM Products WHERE Id = @id";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedText.ToString();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    // Действия, если выбрано значение "1"
                    break;
                case 1:
                    labelProduct2.Visible = true;
                    productComboBox2.Visible = true;
                    labelPrice2.Visible = true;
                    textCount2.Visible = true;
                    priceLabel2.Visible = true;
                    labelCount2.Visible = true;

                    break;
                case 2:
                    labelProduct2.Visible = true;
                    productComboBox2.Visible = true;
                    labelPrice2.Visible = true;
                    textCount2.Visible = true;
                    priceLabel2.Visible = true;
                    labelCount2.Visible = true;

                    labelProduct3.Visible = true;
                    productComboBox3.Visible = true;
                    labelPrice3.Visible = true;
                    textCount3.Visible = true;
                    priceLabel3.Visible = true;
                    labelCount3.Visible = true;
                    break;
                case 3:
                    labelProduct2.Visible = true;
                    productComboBox2.Visible = true;
                    labelPrice2.Visible = true;
                    textCount2.Visible = true;
                    priceLabel2.Visible = true;
                    labelCount2.Visible = true;

                    labelProduct3.Visible = true;
                    productComboBox3.Visible = true;
                    labelPrice3.Visible = true;
                    textCount3.Visible = true;
                    priceLabel3.Visible = true;
                    labelCount3.Visible = true;

                    labelProduct4.Visible = true;
                    productComboBox4.Visible = true;
                    labelPrice4.Visible = true;
                    textCount4.Visible = true;
                    priceLabel4.Visible = true;
                    labelCount4.Visible = true;
                    break;
                default:
                    // Действия по умолчанию, если выбрано неизвестное значение
                    break;
            }
        }
    }
}
