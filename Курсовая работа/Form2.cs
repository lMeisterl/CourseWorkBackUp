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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void drawing1_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.ShowDialog();
        }

        private void drawing2_Click(object sender, EventArgs e)
        {

        }

        private void drawing3_Click(object sender, EventArgs e)
        {
            PurchaseOrders purchaseOrders = new PurchaseOrders();
            purchaseOrders.ShowDialog();
        }

        private void drawing4_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery();
            delivery.ShowDialog();
        }

        private void drawing5_Click(object sender, EventArgs e)
        {

        }

        private void drawing6_Click(object sender, EventArgs e)
        {

        }

        private void drawing8_Click(object sender, EventArgs e)
        {
            ReportPremium reportPremium = new ReportPremium();
            reportPremium.ShowDialog();
        }

        private void drawing7_Click(object sender, EventArgs e)
        {
            ReportOtpuck reportOtpuck = new ReportOtpuck();
            reportOtpuck.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\shtok\\Desktop\\CourseWorkBackUp\\guide.docx");
        }
    }
}
