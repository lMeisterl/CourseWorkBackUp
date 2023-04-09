using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using Word = Microsoft.Office.Interop.Word;
using MetroFramework.Forms;
using MetroFramework.Fonts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсовая_работа
{
    public partial class ReportPremium : Form
    {
        public readonly string TemplateFileName = @"\Resources\premia.docx";
        public ReportPremium()
        {
            InitializeComponent();
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var predname = textBox1.Text;
            var code = textBox2.Text;
            var coder = textBox3.Text;
            var dirname = textBox4.Text;
            var tabel = textBox5.Text;
            var docnumber = textBox6.Text;
            var motiv = textBox7.Text;
            var gift = comboBox1.Text;
            var osnov = textBox9.Text;
            var name = textBox13.Text;
            var strpod = textBox14.Text;
            var dolzh = textBox15.Text;
            var sozdata = dateTimePicker1.Value.ToShortDateString();


            //TODO Word Export
            var wordApp = new Word.Application();
            wordApp.Visible = true;

            try
            {
                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{orgname}", predname, wordDocument);
                ReplaceWordStub("{code}", code, wordDocument);
                ReplaceWordStub("{coder}", coder, wordDocument);
                ReplaceWordStub("{dirname}", dirname, wordDocument);
                ReplaceWordStub("{docnumber}", docnumber, wordDocument);
                ReplaceWordStub("{name}", name, wordDocument);
                ReplaceWordStub("{sozdata}", sozdata, wordDocument);
                ReplaceWordStub("{tabel}", tabel, wordDocument);
                ReplaceWordStub("{strpod}", strpod, wordDocument);
                ReplaceWordStub("{dolzh}", dolzh, wordDocument);
                ReplaceWordStub("{motiv}", motiv, wordDocument);
                ReplaceWordStub("{gift}", gift, wordDocument);
                ReplaceWordStub("{osnov}", osnov, wordDocument);


                wordDocument.SaveAs(@"C:\Users\shtok\OneDrive\Рабочий стол\'" + textBox8+"'.docx");
                wordDocument.Close();
                Process.Start(@"C:\Users\shtok\OneDrive\Рабочий стол\'" + textBox8+"'.docx");

            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }


            finally
            {
                wordApp.Quit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Close();
        }
    }
}
