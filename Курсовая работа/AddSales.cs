using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.kursDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.kursDataSet.Products);

            Load_Product1();
            Load_Product2();
            Load_Product3();
            Load_Product4();
            Load_Employees();

        }
        private void Load_Employees()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True"))
            {
                string query = "SELECT Id, Surname FROM Employees";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                comboBox3.DisplayMember = "Id";
                comboBox3.ValueMember = "Id";
                comboBox3.DataSource = dataTable;
                comboBox3.SelectedIndexChanged += new EventHandler(comboBox3_SelectedIndexChanged);
                comboBox3_SelectedIndexChanged(null, null);
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedValue != null)
            {
                DataRowView row = comboBox3.SelectedItem as DataRowView;
            }
        }
        private void Load_Product1()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True"))
            {
                string query = "SELECT Id, Price FROM Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                productComboBox1.DisplayMember = "Id";
                productComboBox1.ValueMember = "Id";
                productComboBox1.DataSource = dataTable;

                // Set the price and quantity labels for the selected product
                if (productComboBox1.SelectedValue != null)
                {
                    DataRowView row = productComboBox1.SelectedItem as DataRowView;
                    priceLabel1.Text = row["Price"].ToString();
                    //*quantityLabel.Text = row["Count"].ToString();*//*
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
                //*quantityLabel.Text = row["Count"].ToString();*//*
            }
        }
        private void Load_Product2()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True"))
            {
                string query = "SELECT Id, Price FROM Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                productComboBox2.DisplayMember = "Id";
                productComboBox2.ValueMember = "Id";
                productComboBox2.DataSource = dataTable;

                // Set the price and quantity labels for the selected product
                if (productComboBox2.SelectedValue != null)
                {
                    DataRowView row = productComboBox1.SelectedItem as DataRowView;
                    priceLabel2.Text = row["Price"].ToString();
                    //*quantityLabel.Text = row["Count"].ToString();*//*
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
                //*quantityLabel.Text = row["Count"].ToString();*//*
            }
        }
        private void Load_Product3()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True"))
            {
                string query = "SELECT Id, Price FROM Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                productComboBox3.DisplayMember = "Id";
                productComboBox3.ValueMember = "Id";
                productComboBox3.DataSource = dataTable;

                // Set the price and quantity labels for the selected product
                if (productComboBox3.SelectedValue != null)
                {
                    DataRowView row = productComboBox3.SelectedItem as DataRowView;
                    priceLabel1.Text = row["Price"].ToString();
                    //*quantityLabel.Text = row["Count"].ToString();*//*
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
                //*quantityLabel.Text = row["Count"].ToString();*//*
            }
        }
        private void Load_Product4()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True"))
            {
                string query = "SELECT Id, Price FROM Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                productComboBox4.DisplayMember = "Id";
                productComboBox4.ValueMember = "Id";
                productComboBox4.DataSource = dataTable;

                // Set the price and quantity labels for the selected product
                if (productComboBox4.SelectedValue != null)
                {
                    DataRowView row = productComboBox4.SelectedItem as DataRowView;
                    priceLabel4.Text = row["Price"].ToString();
                    //*quantityLabel.Text = row["Count"].ToString();*//*
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
                //*quantityLabel.Text = row["Count"].ToString();*//*
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oneProduct(Int32 id)
        { 
            int countProduct = getCountProduct(id);
            int priceProduct = getPriceProduct(id);
            int finalCount = countProduct - Convert.ToInt32(textCount1.Text);
            int finalPrice = priceProduct * Convert.ToInt32(textCount1.Text);
            textFinishCost.Text = Convert.ToString(finalPrice);
            SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection.Open();
            string query = "UPDATE Products SET Count = @count WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@count", finalCount);
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void twoProduct(int Id1, int Id2)
        {

            int countProduct = getCountProduct(Id1);
            int priceProduct = getPriceProduct(Id1);
            int countProduct2 = getCountProduct(Id2);
            int priceProduct2 = getPriceProduct(Id2);
            int finalCountProduct1 = countProduct - Convert.ToInt32(textCount1.Text);
            int finalCountProduct2 = countProduct2 - Convert.ToInt32(textCount2.Text);
            int finalPriceProduct1 = priceProduct * Convert.ToInt32(textCount1.Text);
            int finalPriceProduct2 = priceProduct2 * Convert.ToInt32(textCount2.Text);
            int finalPrice = finalPriceProduct1 + finalPriceProduct2;
            textFinishCost.Text = Convert.ToString(finalPrice);
            SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection.Open();
            string query = "UPDATE Products SET Count = @count WHERE Id = @Id";
            SqlCommand commandProduct = new SqlCommand(query, connection);
            commandProduct.Parameters.AddWithValue("@Id", Id1);
            commandProduct.Parameters.AddWithValue("@count", finalCountProduct1);
            string quer = "UPDATE Products SET Count = @count WHERE Id = @Id";
            SqlCommand commandProduct2 = new SqlCommand(quer, connection);
            commandProduct2.Parameters.AddWithValue("@Id", Id2);
            commandProduct2.Parameters.AddWithValue("@count", finalCountProduct2);
            commandProduct.ExecuteNonQuery();
            connection.Close();
        }
        private void threeProduct(int Id1, int Id2, int Id3)
        {
            int countProduct = getCountProduct(Id1);
            int priceProduct = getPriceProduct(Id1);
            int countProduct2 = getCountProduct(Id2);
            int priceProduct2 = getPriceProduct(Id2);
            int countProduct3 = getPriceProduct(Id3);
            int priceProduct3 = getPriceProduct(Id3);
            int finalCountProduct1 = countProduct - Convert.ToInt32(textCount1.Text);
            int finalCountProduct2 = countProduct2 - Convert.ToInt32(textCount2.Text);
            int finalPriceProduct1 = priceProduct * Convert.ToInt32(textCount1.Text);
            int finalPriceProduct2 = priceProduct2 * Convert.ToInt32(textCount2.Text);
            int finalCountProduct3 = countProduct3 - Convert.ToInt32(textCount3.Text);
            int finalPriceProduct3 = priceProduct3 * Convert.ToInt32(textCount3.Text);
            int finalPrice = finalPriceProduct1 + finalPriceProduct2 + finalPriceProduct3;
            textFinishCost.Text = Convert.ToString(finalPrice);
            SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection.Open();
            string query = "UPDATE Products SET Count = @count WHERE Id = @Id";
            SqlCommand commandProduct = new SqlCommand(query, connection);
            commandProduct.Parameters.AddWithValue("@Id", Id1);
            commandProduct.Parameters.AddWithValue("@count", finalCountProduct1);
            string quer = "UPDATE Products SET Count = @count WHERE Id = @Id";
            SqlCommand commandProduct2 = new SqlCommand(quer, connection);
            commandProduct2.Parameters.AddWithValue("@Id", Id2);
            commandProduct2.Parameters.AddWithValue("@count", finalCountProduct2);
            string que = "UPDATE Products SET Count = @count WHERE Id = @Id";
            SqlCommand commandProduct3 = new SqlCommand(que, connection);
            commandProduct3.Parameters.AddWithValue("@Id", Id3);
            commandProduct3.Parameters.AddWithValue("@count", finalCountProduct3);
            commandProduct3.ExecuteNonQuery();
            commandProduct2.ExecuteNonQuery();
            commandProduct.ExecuteNonQuery();
            connection.Close();
        }

        private void fourProduct (int Id1, int Id2, int Id3, int Id4) 
        {
            int countProduct = getCountProduct(Id1);
            int priceProduct = getPriceProduct(Id1);
            int countProduct2 = getCountProduct(Id2);
            int priceProduct2 = getPriceProduct(Id2);
            int countProduct3 = getPriceProduct(Id3);
            int priceProduct3 = getPriceProduct(Id3);
            int countProduct4 = getPriceProduct(Id4);
            int priceProduct4 = getPriceProduct(Id4);
            int finalCountProduct1 = countProduct - Convert.ToInt32(textCount1.Text);
            int finalCountProduct2 = countProduct2 - Convert.ToInt32(textCount2.Text);
            int finalPriceProduct1 = priceProduct * Convert.ToInt32(textCount1.Text);
            int finalPriceProduct2 = priceProduct2 * Convert.ToInt32(textCount2.Text);
            int finalCountProduct3 = countProduct3 - Convert.ToInt32(textCount3.Text);
            int finalPriceProduct3 = priceProduct3 * Convert.ToInt32(textCount3.Text);
            int finalCountProduct4 = countProduct4 - Convert.ToInt32(textCount4.Text);
            int finalPriceProduct4 = priceProduct4 * Convert.ToInt32(textCount4.Text);
            int finalPrice = finalPriceProduct1 + finalPriceProduct2 + finalPriceProduct3 + finalPriceProduct4;
            textFinishCost.Text = Convert.ToString(finalPrice);
            SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection.Open();
            string query = "UPDATE Products SET Count = @count WHERE Id = @Id";
            SqlCommand commandProduct = new SqlCommand(query, connection);
            commandProduct.Parameters.AddWithValue("@Id", Id1);
            commandProduct.Parameters.AddWithValue("@count", finalCountProduct1);
            string quer = "UPDATE Products SET Count = @count WHERE Id = @Id";
            SqlCommand commandProduct2 = new SqlCommand(quer, connection);
            commandProduct2.Parameters.AddWithValue("@Id", Id2);
            commandProduct2.Parameters.AddWithValue("@count", finalCountProduct2);
            string que = "UPDATE Products SET Count = @count WHERE Id = @Id";
            SqlCommand commandProduct3 = new SqlCommand(que, connection);
            commandProduct3.Parameters.AddWithValue("@Id", Id3);
            commandProduct3.Parameters.AddWithValue("@count", finalCountProduct3);
            string qu = "UPDATE Products SET Count = @count WHERE Id = @Id";
            SqlCommand commandProduct4 = new SqlCommand(qu, connection);
            commandProduct4.Parameters.AddWithValue("@Id", Id4);
            commandProduct4.Parameters.AddWithValue("@count", finalCountProduct4);
            commandProduct4.ExecuteNonQuery();
            commandProduct3.ExecuteNonQuery();
            commandProduct2.ExecuteNonQuery();
            commandProduct.ExecuteNonQuery();
            connection.Close();
        }

        private int getPriceProduct(Int32 Id) 
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection.Open();
            string query = "SELECT Price FROM Products WHERE Id = @id";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@Id", Id);
            Int32 resultPrice = Convert.ToInt32(sqlCommand.ExecuteScalar());

            return resultPrice;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = comboBox1.SelectedText.ToString();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    // Действия, если выбрано значение "1"
                    labelProduct2.Visible = false;
                    productComboBox2.Visible = false;
                    labelPrice2.Visible = false;
                    textCount2.Visible = false;
                    priceLabel2.Visible = false;
                    labelCount2.Visible = false;

                    labelProduct3.Visible = false;
                    productComboBox3.Visible = false;
                    labelPrice3.Visible = false;
                    textCount3.Visible = false;
                    priceLabel3.Visible = false;
                    labelCount3.Visible = false;

                    labelProduct4.Visible = false;
                    productComboBox4.Visible = false;
                    labelPrice4.Visible = false;
                    textCount4.Visible = false;
                    priceLabel4.Visible = false;
                    labelCount4.Visible = false;
                    break;
                case 1:
                    labelProduct2.Visible = true;
                    productComboBox2.Visible = true;
                    labelPrice2.Visible = true;
                    textCount2.Visible = true;
                    priceLabel2.Visible = true;
                    labelCount2.Visible = true;

                    labelProduct3.Visible = false;
                    productComboBox3.Visible = false;
                    labelPrice3.Visible = false;
                    textCount3.Visible = false;
                    priceLabel3.Visible = false;
                    labelCount3.Visible = false;

                    labelProduct4.Visible = false;
                    productComboBox4.Visible = false;
                    labelPrice4.Visible = false;
                    textCount4.Visible = false;
                    priceLabel4.Visible = false;
                    labelCount4.Visible = false;

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

                    labelProduct4.Visible = false;
                    productComboBox4.Visible = false;
                    labelPrice4.Visible = false;
                    textCount4.Visible = false;
                    priceLabel4.Visible = false;
                    labelCount4.Visible = false;
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drawing1_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = $"INSERT INTO Sales (Id_Employees, Data_of_Sale, Id_Product, Count, Id_Products1, Count1, Id_Products2, Count2, Id_Products3, Count3, Sale_Amount, Payment) VALUES ('" + comboBox3.Text + "','" + dateTimePicker1.Value + "', '" + productComboBox1.Text + "',  '" + textCount1.Text + "', '" + productComboBox2.Text + "', '" + textCount2.Text + "', '" + productComboBox3.Text + "', '" + textCount3.Text + "', '" + productComboBox4.Text + "', '" + textCount4.Text + "', '" + textFinishCost.Text + "', '" + comboBox2.Text + "')";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
            MessageBox.Show("Продажа прошла!");
            this.Close();
            
        }

        private void drawing2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.kursDataSet.Products);
        }

        private void drawing3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1")
            {
                int Id = Convert.ToInt32(productComboBox1.Text);
                oneProduct(Id);
            }
            else if (comboBox1.Text == "2")
            {
                int Id1 = Convert.ToInt32(productComboBox1.Text);
                int Id2 = Convert.ToInt32(productComboBox2.Text);
                twoProduct(Id1, Id2);
            }
            else if (comboBox1.Text == "3")
            {
                int Id1 = Convert.ToInt32(productComboBox1.Text);
                int Id2 = Convert.ToInt32(productComboBox2.Text);
                int Id3 = Convert.ToInt32(productComboBox3.Text);
                threeProduct(Id1, Id2, Id3);
            }
            else if (comboBox1.Text == "4")
            {
                int Id1 = Convert.ToInt32(productComboBox1.Text);
                int Id2 = Convert.ToInt32(productComboBox2.Text);
                int Id3 = Convert.ToInt32(productComboBox3.Text);
                int Id4 = Convert.ToInt32(productComboBox4.Text);
                fourProduct(Id1, Id2, Id3, Id4);
            }
            else
            {
                MessageBox.Show("Нет заполненых продуктов!");
            }
        }

        private void drawing4_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр класса PrintDocument
            PrintDocument pd = new PrintDocument();

            // Обработчик события PrintPage вызывается при каждой странице печати
            pd.PrintPage += new PrintPageEventHandler(this.PrintReceipt);

            // Устанавливаем принтер по умолчанию
            pd.PrinterSettings.PrinterName = PrinterSettings.InstalledPrinters[0];

            // Вызываем диалоговое окно настройки принтера
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Запускаем процесс печати
                pd.Print();
            }
        }
        private void PrintReceipt(object sender, PrintPageEventArgs e)
        {
            // Получаем графический контекст печати
            Graphics g = e.Graphics;

            // Устанавливаем шрифт для печати
            Font font = new Font("Arial", 10);

            // Задаем координаты для печати
            int x = 10;
            int y = 10;

            // Выводим заголовок чека
            g.DrawString("Чек", font, Brushes.Black, x, y);

            // Увеличиваем координату y на высоту строки
            y += (int)font.GetHeight();

            g.DrawString("Сотрудник:" + comboBox3.Text, font, Brushes.Black, x, y);
            y += (int)font.GetHeight();

            g.DrawString("Количество товаров: " + comboBox1.Text, font, Brushes.Black, x, y);
            y += (int)font.GetHeight();

            g.DrawString("Дата продажи:" + dateTimePicker1.Text,font, Brushes.Black, x, y);
            y += (int)font.GetHeight();

            // Выводим данные из comboBox1, comboBox2, textBox1, textBox2 и label1
            g.DrawString("Название товара: " + productComboBox1.Text, font, Brushes.Black, x, y);
            y += (int)font.GetHeight();

            g.DrawString("Количество: " + textCount1.Text, font, Brushes.Black, x, y);
            y += (int)font.GetHeight();

            g.DrawString("Цена: " + priceLabel1.Text, font, Brushes.Black, x, y);
            y += (int)font.GetHeight();

            g.DrawString("Название товара: " + productComboBox2.Text, font, Brushes.Black, x, y);
            y += (int)font.GetHeight();

            g.DrawString("Количество: " + textCount2.Text, font, Brushes.Black, x, y);
            y += (int)font.GetHeight();

            g.DrawString("Цена: " + priceLabel2.Text, font, Brushes.Black, x, y);
            y += (int)font.GetHeight();

            g.DrawString("Название товара: " + productComboBox3.Text, font, Brushes.Black, x, y);
            y += (int)font.GetHeight();

            g.DrawString("Количество: " + textCount3.Text, font, Brushes.Black, x, y);
            y += (int)font.GetHeight();

            g.DrawString("Цена: " + priceLabel3.Text, font, Brushes.Black, x, y);
            y += (int)font.GetHeight();

            g.DrawString("Название товара: " + productComboBox4.Text, font, Brushes.Black, x, y);
            y += (int)font.GetHeight();

            g.DrawString("Количество: " + textCount4.Text, font, Brushes.Black, x, y);
            y += (int)font.GetHeight();

            g.DrawString("Цена: " + priceLabel4.Text, font, Brushes.Black, x, y);
            y += (int)font.GetHeight();

            g.DrawString("Итого: " + textFinishCost.Text, font, Brushes.Black, x, y);
            y += (int)font.GetHeight();

            g.DrawString("Способ оплаты: " + comboBox2.Text, font, Brushes.Black, x, y);
            y += (int)font.GetHeight();
        }

    }
}
