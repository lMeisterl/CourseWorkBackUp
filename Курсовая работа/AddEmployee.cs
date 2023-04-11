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
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Odbc;

namespace Курсовая_работа
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e )
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = "INSERT INTO Employees (First_Name, Surname, Middle_Name, Telephone, Passport, Gender, Date_of_Birth, Job_Title, Education) VALUES (@name, @surname, @MidleName, @Telephone, @Passport, @Gender, @DataBirth, @Post, @Education)";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.Parameters.AddWithValue("@name", tbName.Text);
            sqlCommand.Parameters.AddWithValue("@surname", tbSurname.Text);
            sqlCommand.Parameters.AddWithValue("@MidleName", tbMidleName.Text);
            sqlCommand.Parameters.AddWithValue("@Telephone", maskedTextBox1.Text);
            sqlCommand.Parameters.AddWithValue("@Passport", tbPassport.Text);
            sqlCommand.Parameters.AddWithValue("@Gender", tbGender.Text);
            sqlCommand.Parameters.AddWithValue("@DataBirth", tbDataBirth.Value);
            sqlCommand.Parameters.AddWithValue("@Post", tbPost.Text);
            sqlCommand.Parameters.AddWithValue("@Education", tbEducation.Text);
            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
            Form3 sf = new Form3();          
            sf.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fs = new Form3();
            fs.Show();
            this.Close();
        }

        private void drawing1_Click(object sender, EventArgs e)
        {
            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            connection_new.Open();
            string insertQuery = "INSERT INTO Employees (First_Name, Surname, Middle_Name, Telephone, Passport, Gender, Date_of_Birth, Job_Title, Education, Experience) VALUES (@name, @surname, @MidleName, @Telephone, @Passport, @Gender, @DataBirth, @Post, @Education, @Experience)";
            SqlCommand sqlCommand = new SqlCommand(insertQuery, connection_new);
            sqlCommand.Parameters.AddWithValue("@name", tbName.Text);
            sqlCommand.Parameters.AddWithValue("@surname", tbSurname.Text);
            sqlCommand.Parameters.AddWithValue("@MidleName", tbMidleName.Text);
            sqlCommand.Parameters.AddWithValue("@Telephone", maskedTextBox1.Text);
            sqlCommand.Parameters.AddWithValue("@Passport", tbPassport.Text);
            sqlCommand.Parameters.AddWithValue("@Gender", tbGender.Text);
            sqlCommand.Parameters.AddWithValue("@DataBirth", tbDataBirth.Value);
            sqlCommand.Parameters.AddWithValue("@Post", tbPost.Text);
            sqlCommand.Parameters.AddWithValue("@Education", tbEducation.Text);
            sqlCommand.Parameters.AddWithValue("@Experience", textExp.Text);

            sqlCommand.ExecuteNonQuery();
            connection_new.Close();
            this.Close();
        }

        private void drawing2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

