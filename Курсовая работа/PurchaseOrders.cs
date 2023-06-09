﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая_работа.KursDataSetTableAdapters;

namespace Курсовая_работа
{
    public partial class PurchaseOrders : Form
    {
        int selectedRow;
        public PurchaseOrders()
        {
            InitializeComponent();
        }

        private void PurchaseOrders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.PurchaseOrders". При необходимости она может быть перемещена или удалена.
            this.purchaseOrdersTableAdapter.Fill(this.kursDataSet.PurchaseOrders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._Orders_id". При необходимости она может быть перемещена или удалена.
            this.orders_idTableAdapter.Fill(this.kursDataSet._Orders_id);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.PurchaseOrders". При необходимости она может быть перемещена или удалена.
            this.purchaseOrdersTableAdapter.Fill(this.kursDataSet.PurchaseOrders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._Orders_id". При необходимости она может быть перемещена или удалена.
            this.orders_idTableAdapter.Fill(this.kursDataSet._Orders_id);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._Orders_id". При необходимости она может быть перемещена или удалена.
            this.orders_idTableAdapter.Fill(this.kursDataSet._Orders_id);

            ToolTip d = new ToolTip();
            d.SetToolTip(drawing2, "Удалить");
            ToolTip f = new ToolTip();
            f.SetToolTip(button9, "Закрыть");
            ToolTip r = new ToolTip();
            r.SetToolTip(button6, "Обновить");
            ToolTip back = new ToolTip();
            back.SetToolTip(button8, "Назад");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddOrders addOrders = new AddOrders();
            addOrders.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.orders_idTableAdapter.Fill(this.kursDataSet._Orders_id);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textID.Text = row.Cells[0].Value.ToString();
                textSupl.Text = row.Cells[1].Value.ToString();
                textProd.Text = row.Cells[2].Value.ToString();
                textEmp.Text = row.Cells[3].Value.ToString();
                textCount.Text = row.Cells[4].Value.ToString();
                dateTimePicker1.Text = row.Cells[5].Value.ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.orders_idTableAdapter.Fill(this.kursDataSet._Orders_id);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void drawing2_Click(object sender, EventArgs e)
        {
            // Проверяем, что пользователь выделил строку в DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выделите строку для удаления.");
                return;
            }

            // Получаем ID строки, которую нужно удалить
            int rowId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            // Создаем подключение к базе данных
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");

            try
            {

                // Открываем подключение
                connection_new.Open();

                // Создаем команду для удаления строки из таблицы
                SqlCommand command = new SqlCommand("DELETE FROM PurchaseOrders WHERE Id = @Id", connection_new);

                // Добавляем параметр для ID строки
                command.Parameters.AddWithValue("@Id", rowId);

                // Выполняем команду и получаем количество удаленных строк
                int rowsAffected = command.ExecuteNonQuery();

                // Если удалено 0 или более 1 строк, выводим сообщение об ошибке
                if (rowsAffected != 1)
                {
                    MessageBox.Show("Ошибка при удалении строки.");
                    return;
                }

                // Удаляем строку из DataGridView
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                // Выводим сообщение об успешном удалении строки
                MessageBox.Show("Строка удалена.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении строки из базы данных: " + ex.Message);
            }
        }

        private void drawing3_Click(object sender, EventArgs e)
        {
            AddOrders addOrders = new AddOrders();
            addOrders.Show();
        }

        private void drawing1_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = "UPDATE PurchaseOrders SET Id_Provider = '" + textSupl.Text + "', Id_Product = '" + textProd.Text + "', Id_Employee = '" + textEmp.Text + "', Count = '" + textCount.Text + "',Delivery_Date = '" + dateTimePicker1.Value + "'";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
            
        }

        private void button1_Click_2(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [Orders+id]", connection_new);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0];

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"[Сотрудник] LIKE '%{textBox1.Text}%'";
            connection_new.Close();
        }
    }
}
