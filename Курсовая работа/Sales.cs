using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._Sales_id". При необходимости она может быть перемещена или удалена.
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
                textBox3.Text = row.Cells[2].Value.ToString();
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
                textBox17.Text = row.Cells[16].Value.ToString();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.sales_idTableAdapter.Fill(this.kursDataSet._Sales_id);
        }
    }
}
