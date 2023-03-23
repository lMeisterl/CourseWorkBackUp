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
using System.Xml.Linq;

namespace Курсовая_работа
{
    public partial class EditProducts : Form
    {
        public EditProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
            {
                Products ht = new Products();
                ht.Show();
                this.Close();
            }

        private void EditProducts_Load(object sender, EventArgs e)
        {
            
        }
    }
    
}
