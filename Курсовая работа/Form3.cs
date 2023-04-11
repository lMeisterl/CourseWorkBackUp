using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Excel = Microsoft.Office.Interop.Excel;


namespace Курсовая_работа
{
    public partial class Form3 : Form
    {
        int selectedRow;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.kursDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.kursDataSet.Employees);
            ToolTip d = new ToolTip();
            d.SetToolTip(drawing2, "Удалить");
            ToolTip v = new ToolTip();
            v.SetToolTip(drawing1, "Добавить");
            ToolTip f = new ToolTip();
            f.SetToolTip(button5, "Закрыть");
            ToolTip r = new ToolTip();
            r.SetToolTip(button7, "Обновить");
            ToolTip back = new ToolTip();
            back.SetToolTip(button4, "Назад");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployee sa = new AddEmployee();
            sa.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
                employeesTableAdapter.Update(kursDataSet);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* // Worker => Edit...
            EditProducts f = new EditProducts();
            int index;
            string First_Name, Surname, Middle_Name, Telephone, Passport, Gender, Date_of_Birth, Job_Title, Education;
            int id;

            if (dataGridView1.RowCount <= 1) return;

            // получить позицию выделенной строки в dataGridView1
            index = dataGridView1.CurrentRow.Index;

            if (index == dataGridView1.RowCount - 1) return; //

            // получить данные строки
            id = (int)dataGridView1.Rows[index].Cells[0].Value;
            First_Name = (string)dataGridView1.Rows[index].Cells[1].Value;
            Surname = (string)dataGridView1.Rows[index].Cells[2].Value;
            Middle_Name = (string)dataGridView1.Rows[index].Cells[3].Value;
            Telephone = (string)dataGridView1.Rows[index].Cells[4].Value;
            Passport = (string)dataGridView1.Rows[index].Cells[5].Value;
            Gender = (string)dataGridView1.Rows[index].Cells[6].Value;
            Date_of_Birth = (string)dataGridView1.Rows[index].Cells[7].Value;
            Job_Title = (string)dataGridView1.Rows[index].Cells[8].Value;
            Education = (string)dataGridView1.Rows[index].Cells[9].Value;

            // заполнить поля формы f

            if (f.ShowDialog() == DialogResult.OK) // вызвать форму FormEditWorker
            {

                // получить новые (измененные) значения из формы
                SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
                string insertQuery = "INSERT INTO Employees (First_Name, Surname, Middle_Name, Telephone, Passport, Gender, Date_of_Birth, Job_Title, Education) VALUES (@name, @surname, @MidleName, @Telephone, @Passport, @Gender, @DataBirth, @Post, @Education)";
                SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
                sqlCommand.Parameters.AddWithValue("@name", f.textBox1.Text);
                sqlCommand.Parameters.AddWithValue("@surname", f.textBox2.Text);
                sqlCommand.Parameters.AddWithValue("@MidleName", f.textBox3.Text);
                sqlCommand.Parameters.AddWithValue("@Telephone", f.textBox4.Text);
                sqlCommand.Parameters.AddWithValue("@Passport", f.textBox5.Text);
                sqlCommand.Parameters.AddWithValue("@Gender", f.textBox6.Text);
                sqlCommand.Parameters.AddWithValue("@DataBirth", f.textBox7.Text);
                sqlCommand.Parameters.AddWithValue("@Post", f.textBox8.Text);
                sqlCommand.Parameters.AddWithValue("@Education", f.textBox9.Text);
                sqlCommand.ExecuteNonQuery();
                connection_new.Close();
                // сделать изменения в адаптере
                this.employeesTableAdapter.Fill(this.kursDataSet.Employees);
            }*/
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            /*DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            row.Cells[1].Value = textBox3.Text;
            row.Cells[2].Value = textBox4.Text;
            row.Cells[3].Value = textBox5.Text;
            row.Cells[4].Value = maskedTextBox1.Text;
            row.Cells[5].Value = textBox7.Text;
            row.Cells[6].Value = textBox8.Text;
            row.Cells[7].Value = dateTimePicker1.Text;
            row.Cells[8].Value = textBox10.Text;
            row.Cells[9].Value = textBox11.Text;*/
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = "UPDATE Employees SET First_Name = '"+textBox3.Text+"', Surname = '"+textBox4.Text+"', Middle_Name = '"+textBox5.Text+"', Telephone = '"+maskedTextBox1.Text+"', Passport = '"+maskedTextBox2.Text+"', Gender = '"+comboBox1.Text+"', Date_of_Birth = '"+dateTimePicker1.Value+"', Job_Title = '"+textBox10.Text+"', Education = '"+textBox11.Text+"'WHERE Id = '"+textBox2.Text+"'";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
            this.employeesTableAdapter.Fill(this.kursDataSet.Employees);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddLogin addLogin = new AddLogin();
            addLogin.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox2.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
                textBox4.Text = row.Cells[2].Value.ToString();
                textBox5.Text = row.Cells[3].Value.ToString();
                maskedTextBox1.Text = row.Cells[4].Value.ToString();
                maskedTextBox2.Text = row.Cells[5].Value.ToString();
                comboBox1.Text = row.Cells[6].Value.ToString();
                dateTimePicker1.Text = row.Cells[7].Value.ToString();
                textBox10.Text = row.Cells[8].Value.ToString();
                textBox11.Text = row.Cells[9].Value.ToString();
                textBox12.Text = row.Cells[10].Value.ToString();

            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.kursDataSet.Employees);
        }

        private void button8_Click(object sender, EventArgs e)
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

        private void drawing1_Click(object sender, EventArgs e)
        {
            AddEmployee sa = new AddEmployee();
            sa.ShowDialog();
        }

        private void drawing2_Click(object sender, EventArgs e)
        {
            CurrencyManager CurMan = (CurrencyManager)dataGridView1.BindingContext[dataGridView1.DataSource];
            if (CurMan.Count > 0)
            {
                CurMan.RemoveAt(CurMan.Position);
                employeesTableAdapter.Update(kursDataSet);
            }
        }

        private void drawing3_Click(object sender, EventArgs e)
        {
            AddLogin addLogin = new AddLogin();
            addLogin.ShowDialog();
        }

        private void drawing4_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = "UPDATE Employees SET First_Name = '" + textBox3.Text + "', Surname = '" + textBox4.Text + "', Middle_Name = '" + textBox5.Text + "', Telephone = '" + maskedTextBox1.Text + "', Passport = '" + maskedTextBox2.Text + "', Gender = '" + comboBox1.Text + "', Date_of_Birth = '" + dateTimePicker1.Value + "', Job_Title = '" + textBox10.Text + "', Education = '" + textBox11.Text + "'WHERE Id = '" + textBox2.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
            this.employeesTableAdapter.Fill(this.kursDataSet.Employees);
        }
        private string GetCellValue(SpreadsheetDocument document, Cell cell)
        {
            SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;
            if (cell.CellValue == null)
            {
                return "";
            }
            string cellValue = cell.CellValue.InnerXml;
            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                return stringTablePart.SharedStringTable.ChildElements[int.Parse(cellValue)].InnerText;
            }
            else
            {
                return cellValue;
            }
        }

        private void drawing5_Click(object sender, EventArgs e)
        {
            /*// Открыть диалог выбора файла Excel
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return; // Если файл не выбран, выйти из метода
            }

            // Получить путь к файлу Excel
            string filePath = openFileDialog.FileName;

            // Подключиться к БД
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();

            // Создать объект для работы с Excel
            using (OleDbConnection excelConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties='Excel 12.0 Xml;HDR=YES'"))
            {
                excelConnection.Open();

                // Получить данные из листа Excel
                OleDbCommand excelCommand = new OleDbCommand("SELECT * FROM [Лист1$]", excelConnection);
                OleDbDataReader excelReader = excelCommand.ExecuteReader();

                // Заполнить таблицу в БД данными из Excel
                while (excelReader.Read())
                {
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Employees (Id, First_Name, Surname, Middle_Name, Passport, Gender, Job_Title, Education, Experience, Login, Password, is_admin) VALUES (@value1, @value2, @value3), @value4, @value5, @value6, @value7, @value8, @value9, @value10, @value11, @value12, @value13", connection_new);
                    insertCommand.Parameters.AddWithValue("@value1", excelReader.GetString(0));
                    insertCommand.Parameters.AddWithValue("@value2", excelReader.GetString(1));
                    insertCommand.Parameters.AddWithValue("@value3", excelReader.GetString(2));
                    insertCommand.Parameters.AddWithValue("@value4", excelReader.GetString(3));
                    insertCommand.Parameters.AddWithValue("@value5", excelReader.GetString(4));
                    insertCommand.Parameters.AddWithValue("@value6", excelReader.GetString(5));
                    insertCommand.Parameters.AddWithValue("@value7", excelReader.GetString(6));
                    insertCommand.Parameters.AddWithValue("@value8", excelReader.GetString(7));
                    insertCommand.Parameters.AddWithValue("@value9", excelReader.GetString(8));
                    insertCommand.Parameters.AddWithValue("@value10", excelReader.GetString(9));
                    insertCommand.Parameters.AddWithValue("@value11", excelReader.GetString(10));
                    insertCommand.Parameters.AddWithValue("@value12", excelReader.GetString(11));
                    insertCommand.Parameters.AddWithValue("@value13", excelReader.GetString(12));
                    insertCommand.ExecuteNonQuery();
                }

                excelReader.Close();
            }

            connection_new.Close();


            MessageBox.Show("Данные загружены в базу данных.");*/
        }

        private void drawing6_Click(object sender, EventArgs e)
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
    }
}
