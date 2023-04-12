using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Курсовая_работа
{
    public partial class Diagram : Form
    {
        public Diagram()
        {
            InitializeComponent();
        }

        private void drawing1_Click(object sender, EventArgs e)
        {
            // Создание серии данных
            Series series = new Series();
            series.Name = "Продажи";
            series.ChartType = SeriesChartType.Column;

            // Заполнение серии данными из запроса
            using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True"))
            {
                string query = "SELECT MONTH(Data_of_Sale) AS Month, COUNT(*) AS Count FROM Sales GROUP BY MONTH(Data_of_Sale) ORDER BY Month ASC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int month = reader.GetInt32(0);
                            int salesCount = reader.GetInt32(1);
                            series.Points.AddXY(month, salesCount);
                        }
                    }
                }
            }

            // Добавление серии на диаграмму
            chart1.Series.Add(series);

            // Настройка оси X
            chart1.ChartAreas[0].AxisX.Minimum = 1;
            chart1.ChartAreas[0].AxisX.Maximum = 12;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.Title = "Месяц";

            // Настройка оси Y
            chart1.ChartAreas[0].AxisY.Title = "Количество продаж";

            // Обновление диаграммы
            chart1.Invalidate();

            /*chart1.Series.Clear();
            chart1.Legends.Clear();

            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            string query = "SELECT Name, COUNT(*) AS Count FROM [Sales+id] GROUP BY Name ORDER BY Count DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection_new);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            Series series = new Series("[Sales+id]");
            series.ChartType = SeriesChartType.Column;

            foreach (DataRow row in dataTable.Rows)
            {
                string idProducts = row["Name"].ToString();
                int count = Convert.ToInt32(row["Count"]);

                DataPoint point1 = new DataPoint();
                point1.AxisLabel = idProducts;
                point1.SetValueY(count);
                point1.Color = Color.Blue;
                series.Points.Add(point1);

                DataPoint point2 = new DataPoint();
                point2.SetValueXY(idProducts, count);
                point2.IsVisibleInLegend = false;
                point2.SetCustomProperty("PixelPointWidth", "1");
                series.Points.Add(point2);
            }

            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chart1.ChartAreas[0].AxisX.Interval = 1;

            chart1.Invalidate();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drawing2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drawing3_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
