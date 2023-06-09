﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая_работа.KursDataSetTableAdapters;

namespace Курсовая_работа
{
    public partial class Products : Form
    {
        SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
        int selectedRow;
        string imgLoc = "";

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.kursDataSet.Products);

            ToolTip d = new ToolTip();
            d.SetToolTip(drawing2, "Удалить");
            ToolTip f = new ToolTip();
            f.SetToolTip(button9, "Закрыть");
            ToolTip r = new ToolTip();
            r.SetToolTip(button7, "Обновить");
            ToolTip back = new ToolTip();
            back.SetToolTip(button8, "Назад");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProducts gh = new AddProducts();
            gh.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
                productsTableAdapter.Update(kursDataSet);
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = "UPDATE Products SET Name = '"+textBox3.Text+"', Price = '"+maskedTextBox1.Text+"', Type = '"+textBox5.Text+"', Manufacturer = '"+textBox6.Text+"', Producing_Сountry = '"+textBox7.Text+"', Date_of_Manufacture = '"+ textBox8.Text+ "', Count = '"+textBox9.Text+"' WHERE Id = '"+textBox2.Text+"'";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.ExecuteNonQuery();
            this.productsTableAdapter.Fill(this.kursDataSet.Products);
            connection_new.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            connection_new.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Products", connection_new);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0];

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Name LIKE '%{textBox1.Text}%'";
            connection_new.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*selectedRow = e.RowIndex;
            if (selectedRow >=0 ) 
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox2.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
                maskedTextBox1.Text = row.Cells[2].Value.ToString();
                textBox5.Text = row.Cells[3].Value.ToString();
                textBox6.Text = row.Cells[4].Value.ToString();
                textBox7.Text = row.Cells[5].Value.ToString();
                textBox8.Text = row.Cells[6].Value.ToString();
                textBox9.Text = row.Cells[7].Value.ToString();

            }*/
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.Trim();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString().Equals(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        // Highlight the matching row and scroll to it
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.kursDataSet.Products);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.kursDataSet.Products);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drawing1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
                string insertQuery = "UPDATE Products SET Name = '" + textBox3.Text + "', Price = '" + maskedTextBox1.Text + "', Type = '" + textBox5.Text + "', Manufacturer = '" + textBox6.Text + "', Producing_Сountry = '" + textBox7.Text + "', Date_of_Manufacture = '" + textBox8.Text + "', Count = '" + textBox9.Text + "', Image = @img WHERE Id = '" + textBox2.Text + "'";
                if (connection_new.State != ConnectionState.Open)
                    connection_new.Open();
                SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
                sqlCommand.Parameters.Add(new SqlParameter("@img", img));
                int x = sqlCommand.ExecuteNonQuery();
                connection_new.Close();
                MessageBox.Show(x.ToString() + "Успешно изменено!");
                this.productsTableAdapter.Fill(this.kursDataSet.Products);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void drawing3_Click(object sender, EventArgs e)
        {
            AddProducts gh = new AddProducts();
            gh.ShowDialog();
        }

        private void drawing2_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
                productsTableAdapter.Update(kursDataSet);
            }
            MessageBox.Show("Успешно удалено!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.Trim();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString().Equals(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        // Highlight the matching row and scroll to it
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }

        private void drawing4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*)";
                dlg.Title = "Select Films Image";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    picImg.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void drawing5_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT Name, Price, Type, Manufacturer, Producing_Сountry, Date_of_Manufacture, Count, Image FROM Products WHERE Id = '" + textBox2.Text + "'";
                if (connection_new.State != ConnectionState.Open)
                    connection_new.Open();
                SqlCommand command = new SqlCommand(sql, connection_new);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    textBox3.Text = reader[0].ToString();
                    maskedTextBox1.Text = reader[1].ToString();
                    textBox5.Text = reader[2].ToString();
                    textBox6.Text = reader[3].ToString();
                    textBox7.Text = reader[4].ToString();
                    textBox8.Text = reader[5].ToString();
                    textBox9.Text = reader[6].ToString();
                    byte[] img = (byte[])(reader[7]);
                    if (img == null)
                        picImg.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        picImg.Image = Image.FromStream(ms);
                    }

                }
                else
                {
                    MessageBox.Show("Не существует!");
                }
                connection_new.Close();
            }
            catch (Exception ex)
            {
                connection_new.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
