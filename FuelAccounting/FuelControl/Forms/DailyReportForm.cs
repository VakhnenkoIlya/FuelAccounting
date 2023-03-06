using FuelAccounting.Model;
using FuelAccounting.Services;
using System.Collections.Immutable;
using System.Data;
using System.Linq;

namespace FuelControl
{
    public partial class DailyReportForm : Form
    {
        private DailyReportRepositoryService _dailyReport;
        public DailyReportForm(DataGridView autoTable, DailyReportRepositoryService dailyReport)
        {
            InitializeComponent();
          _dailyReport= dailyReport;
            comboBox1.DataSource = autoTable.DataSource;
            comboBox1.DisplayMember = "Model";
            UpdateData();
            CheckFlow();
        }

        private void CarCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            dataGridView1.AutoGenerateColumns = false;
            var car = ((Car)comboBox1.SelectedItem);
            var reports = car.Reports.ToArray();
            dataGridView1.DataSource = reports;
            dataGridView1.Columns["date"].DataPropertyName = "Date";
            dataGridView1.Columns["Fueled"].DataPropertyName = "Fueled";
            dataGridView1.Columns["Mileage"].DataPropertyName = "Mileage";
            dataGridView1.Columns["Column1"].DataPropertyName = "Balance";
            dataGridView1.Columns["Column2"].DataPropertyName = "RestWay";
            dataGridView1.Update();
        }

        private void CheckFlow()
        {
            int fueled = 0;
            int mileage = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                fueled += Convert.ToInt32(dataGridView1[1, i].Value);
                mileage += Convert.ToInt32(dataGridView1[2, i].Value);
            }
            var difference = Math.Round((fueled / ((Car)comboBox1.SelectedItem).Expenditure) * 100 - mileage, 2);
            label1.Text = $"Всего заправлено {fueled} л, пробег по отчетам {mileage} км, разница составляет {difference} км";
            if (difference > 100)
                label1.ForeColor = Color.RosyBrown;
            if (difference < 0)
                label1.Text += " образование излишек";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var car = ((Car)comboBox1.SelectedItem);
            var reports = car.Reports.ToArray();

            //DataTable dt = _dailyReport.db[];
            //DataView DV = new DataView(dt)
            //{
            //    RowFilter = string.Format("[Date] >= #" + Convert.ToDateTime(dateTimePicker1.Text).ToString("MM.dd.yyyy") 
            //    + "# And [Date] <= #" + Convert.ToDateTime(dateTimePicker2.Text).ToString("MM.dd.yyyy") + "#  ")
            //};
            //dataGridView1.DataSource = DV;

           
        }
    }
}
