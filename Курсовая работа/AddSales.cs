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
    }
}
