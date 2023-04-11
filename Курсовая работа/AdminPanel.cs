using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class AdminPanel : Form
    {
        //private readonly chekUser _user;
        private const string V = "186; 231; 96";

        public AdminPanel(/*chekUser user*/)
        {
            //user = _user;
            InitializeComponent();
        }
        /*private void IsAdmin()
        {
            
        }*/

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            //textBox1.Text = $"{_user.login}:{_user.IsAdmin}";
        }

        private void drawing1_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.ShowDialog();
        }

        private void drawing2_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ShowDialog();
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
            Suppliers suppliers = new Suppliers();
            suppliers.ShowDialog();
        }

        private void drawing6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
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
    }
}
