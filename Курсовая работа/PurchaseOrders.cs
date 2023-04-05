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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._Orders_id". При необходимости она может быть перемещена или удалена.
            this.orders_idTableAdapter.Fill(this.kursDataSet._Orders_id);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._Orders_id". При необходимости она может быть перемещена или удалена.
            this.orders_idTableAdapter.Fill(this.kursDataSet._Orders_id);
            

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
                textPrice.Text = row.Cells[5].Value.ToString();
                textDate.Text = row.Cells[6].Value.ToString();
                textStatus.Text = row.Cells[7].Value.ToString();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
