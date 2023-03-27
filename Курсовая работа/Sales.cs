using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._Sales_id". При необходимости она может быть перемещена или удалена.
            this.sales_idTableAdapter.Fill(this.kursDataSet._Sales_id);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet1._Sales_id". При необходимости она может быть перемещена или удалена.
            this.sales_idTableAdapter.Fill(this.kursDataSet._Sales_id);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
