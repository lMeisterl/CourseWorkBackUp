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
    public partial class PurchaseOrders : Form
    {
        public PurchaseOrders()
        {
            InitializeComponent();
        }

        private void PurchaseOrders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet._Orders_id". При необходимости она может быть перемещена или удалена.
            this.orders_idTableAdapter.Fill(this.kursDataSet._Orders_id);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursDataSet.Purchase_Orders". При необходимости она может быть перемещена или удалена.
            this.purchase_OrdersTableAdapter.Fill(this.kursDataSet.Purchase_Orders);

        }
    }
}
