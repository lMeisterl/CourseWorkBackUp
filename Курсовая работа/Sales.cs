using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Курсовая_работа.KursDataSetTableAdapters;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Office.CustomUI;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace Курсовая_работа
{
    public partial class Sales : Form
    {
        int selectedRow;
        public Sales()
        {
            InitializeComponent();
        }
        
        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.kursDataSet.Sales);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._Sales_id". При необходимости она может быть перемещена или удалена.
            this.sales_idTableAdapter.Fill(this.kursDataSet._Sales_id);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.kursDataSet.Sales);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.kursDataSet.Sales);

            ToolTip d = new ToolTip();
            d.SetToolTip(drawing2, "Удалить");
            ToolTip v = new ToolTip();
            v.SetToolTip(drawing3, "Добавить");
            ToolTip f = new ToolTip();
            f.SetToolTip(button10, "Закрыть");
            ToolTip r = new ToolTip();
            r.SetToolTip(button8, "Обновить");
            ToolTip back = new ToolTip();
            back.SetToolTip(button9, "Назад");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSales addSales = new AddSales();
            addSales.Show();
            this.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
                textBox7.Text = row.Cells[6].Value.ToString();
                textBox8.Text = row.Cells[7].Value.ToString();
                textBox9.Text = row.Cells[8].Value.ToString();
                textBox10.Text = row.Cells[9].Value.ToString();
                textBox11.Text = row.Cells[10].Value.ToString();
                textBox12.Text = row.Cells[11].Value.ToString();
                textBox13.Text = row.Cells[12].Value.ToString();
                textBox14.Text = row.Cells[13].Value.ToString();
                textBox15.Text = row.Cells[14].Value.ToString();
                textBox16.Text = row.Cells[15].Value.ToString();
                comboBox1.Text = row.Cells[16].Value.ToString();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.salesTableAdapter.Fill(this.kursDataSet.Sales);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
                salesTableAdapter.Update(kursDataSet);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.salesTableAdapter.Fill(this.kursDataSet.Sales);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void drawing2_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
                salesTableAdapter.Update(kursDataSet);
            }
        }

        private void drawing3_Click(object sender, EventArgs e)
        {
            AddSales addSales = new AddSales();
            addSales.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.sales_idTableAdapter.Fill(this.kursDataSet._Sales_id);
        }

        private void drawing4_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = "UPDATE Sales SET Id_Employees = '" + textBox2.Text + "', Data_of_Sale = '"+dateTimePicker1.Text+"', Id_Product = '" + textBox4.Text + "', Count = '" + textBox6.Text + "', Id_Products1 = '" + textBox7.Text + "', Count1 = '" + textBox9.Text + "', Id_Products2 = '" + textBox10.Text + "', Count2 = '" + textBox12.Text+ "', Id_Products3 = '" + textBox13.Text + "', Count3 = '" + textBox15.Text + "', Sale_Amount = '"+textBox16.Text+ "', Payment = '"+comboBox1.Text+"'WHERE Id = '" + textBox1.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
            this.salesTableAdapter.Fill(this.kursDataSet.Sales);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string searchValue = textBox18.Text.Trim();

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

        private void drawing1_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Add();
            Excel.Worksheet sheet = workbook.Sheets[1];

            // Копирование заголовков столбцов
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                sheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            // Копирование данных из DataGridView
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    sheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            // Сохранение файла Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("Данные успешно экспортированы в Excel!");
            }

            excel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
            excel = null;
        }

        private void drawing4_Click_1(object sender, EventArgs e)
        {
            editingSales editingSales = new editingSales();
            editingSales.ShowDialog();
        }
    }
}
