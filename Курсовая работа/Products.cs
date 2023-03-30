using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
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

        public Products()
        {
            InitializeComponent();
        }
    
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetBoolean(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetInt32(7));
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.kursDataSet.Products);

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

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = textBox2.Text;
            var Name = textBox3.Text;
            var Type = textBox5.Text;
            var Manufacturer = textBox6.Text;
            var Producing_Сountry = textBox7.Text;
            var Date_of_Manufacture = textBox8.Text;
            int price;


            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if(int.TryParse(textBox4.Text, out price))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, Name, Type, Manufacturer, Producing_Сountry, Date_of_Manufacture, price);
                }
                else
                {
                    MessageBox.Show("");
                }
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            //Change();
            DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            row.Cells[1].Value = textBox3.Text;
            row.Cells[2].Value = textBox4.Text;
            row.Cells[3].Value = textBox5.Text;
            row.Cells[4].Value = textBox6.Text;
            row.Cells[5].Value = textBox7.Text;
            row.Cells[6].Value = textBox8.Text;
            row.Cells[7].Value = textBox9.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminPanel hg = new AdminPanel();
            hg.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //Search(dataGridView1);
            /*connection_new.Open();
            string searchString = $"select * from Products where Name LIKE '%" + textBox1.Text + "%'";
            connection_new.Close();*/

            /*SqlCommand command = new SqlCommand(searchString, connection_new);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable bt = new DataTable();
            adapter.Fill(bt);
            dataGridView1.DataSource = bt;
            connection_new.Close();*/
            /*dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(textBox1.Text))
                    {
                        dataGridView1.CurrentCell = row.Cells[1];
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >=0 ) 
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox2.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
                textBox4.Text = row.Cells[2].Value.ToString();
                textBox5.Text = row.Cells[3].Value.ToString();
                textBox6.Text = row.Cells[4].Value.ToString();
                textBox7.Text = row.Cells[5].Value.ToString();
                textBox8.Text = row.Cells[6].Value.ToString();
                textBox9.Text = row.Cells[7].Value.ToString();

            }
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

            /*for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }*/

            /*string searchValue = textBox1.Text.Trim();
            bool found = false;

            // проходим по всем ячейкам DataGridView и ищем заданное значение
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchValue)) // если значение содержит искомое значение
                    {
                        dataGridView1.CurrentCell = cell; // устанавливаем текущую ячейку
                        found = true; // найдено значение
                        break;
                    }
                }
                if (found)
                    break;
            }

            if (!found) // если значение не найдено
                MessageBox.Show("Значение не найдено");*/
        }
    }
}
