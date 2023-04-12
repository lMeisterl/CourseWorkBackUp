using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class ReportOtpuck : Form
    {

        public readonly string TemplateFileName = @"C:\Users\shtok\Desktop\CourseWorkBackUp\otpusk.docx";
        public ReportOtpuck()
        {
            InitializeComponent();
        }
        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void ReportOtpuck_Load(object sender, EventArgs e)
        {
            //Parent.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void drawing1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drawing2_Click(object sender, EventArgs e)
        {
            var predname = textBox1.Text;
            var code = textBox2.Text;
            var coder = textBox3.Text;
            var dirname = textBox4.Text;
            var tabel = textBox5.Text;
            var docnumber = textBox6.Text;
            var name = textBox13.Text;
            var strpod = textBox14.Text;
            var dolzh = textBox15.Text;
            var sozdata = dateTimePicker1.Value.ToShortDateString();
            var dataone = dateTimePicker2.Value.ToShortDateString();
            var datatwo = dateTimePicker3.Value.ToShortDateString();
            var fd = textBox7.Text;
            var datathree = dateTimePicker4.Value.ToShortDateString();
            var datafour = dateTimePicker5.Value.ToShortDateString();
            var document = textBox8.Text;
            var sbk = textBox9.Text;
            var datafive = dateTimePicker6.Value.ToShortDateString();
            var datasix = dateTimePicker7.Value.ToShortDateString();
            var a = textBox10.Text;
            var dataseven = dateTimePicker9.Value.ToShortDateString();
            var dataeight = dateTimePicker8.Value.ToShortDateString();
            var osndoc = textBox11.Text;

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
                ReplaceWordStub("{sosdata}", sozdata, wordDocument);
                ReplaceWordStub("{tabel}", tabel, wordDocument);
                ReplaceWordStub("{strpod}", strpod, wordDocument);
                ReplaceWordStub("{dolzh}", dolzh, wordDocument);
                ReplaceWordStub("{dataone}", dataone, wordDocument);
                ReplaceWordStub("{datatwo}", datatwo, wordDocument);
                ReplaceWordStub("{fd}", fd, wordDocument);
                ReplaceWordStub("{datathree}", datathree, wordDocument);
                ReplaceWordStub("{datafour}", datafour, wordDocument);
                ReplaceWordStub("{document}", document, wordDocument);
                ReplaceWordStub("{sbk}", sbk, wordDocument);
                ReplaceWordStub("{datafive}", datafive, wordDocument);
                ReplaceWordStub("{datasix}", datasix, wordDocument);
                ReplaceWordStub("{a}", a, wordDocument);
                ReplaceWordStub("{dataseven}", dataseven, wordDocument);
                ReplaceWordStub("{dataeight}", dataeight, wordDocument);
                ReplaceWordStub("{osndoc}", osndoc, wordDocument);



                wordDocument.SaveAs(@"C:\Users\shtok\Desktop\'" + textBox12.Text + "'.docx");
                wordDocument.Close();
                Process.Start(@"C:\Users\shtok\Desktop\'" + textBox12.Text + "'.docx");

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
    }
}
