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
            chart1.Series.Clear();
            chart1.Legends.Clear();

            SqlConnection connection_new = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Kurs;Integrated Security=True");
            string query = "SELECT Payment, Sale_Amount, COUNT(*) AS Count FROM Sales GROUP BY Payment, Sale_Amount ORDER BY Count DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection_new);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            Series series = new Series("Sales");
            series.ChartType = SeriesChartType.Column;

            foreach (DataRow row in dataTable.Rows)
            {
                string idProducts = row["Payment"].ToString();
                string idEmployees = row["Sale_Amount"].ToString();
                int count = Convert.ToInt32(row["Count"]);

                DataPoint point1 = new DataPoint();
                point1.AxisLabel = idProducts;
                point1.SetValueY(count);
                point1.Color = Color.Blue;
                point1.LegendText = idEmployees;
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

            chart1.Invalidate();
        }
    }
}
