using FuelAccounting;
using FuelAccounting.Model;
using FuelAccounting.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace FuelControl
{
    public partial class AddReportForm : Form
    {
        public DailyReport report;
        public ICollection<DailyReport> reports;
        private CarsRepositoryService _carRepository;
        private DailyReportRepositoryService _dailyReportRepository;
        private ReportСalculator _reportСalculator;
        public AddReportForm(DataGridView autoTable, CarsRepositoryService carRepository, DailyReportRepositoryService dailyReportRepository)
        {
            InitializeComponent();
            reports = new List<DailyReport>();
            comboBox1.DataSource = autoTable.DataSource;
            comboBox1.DisplayMember = "Model";
            _carRepository = carRepository;
            _dailyReportRepository = dailyReportRepository;
            _reportСalculator = new();
        }


        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MileageTxb.Text) || String.IsNullOrEmpty(FueledTxb.Text))
            {
                MessageBox.Show("Не заполнены поля, отчет не создан");
                return;
            }
            var car = (Car)comboBox1.SelectedItem;
            report = new DailyReport()
            {
                Date = DateTime.Now,
                Mileage = int.Parse(MileageTxb.Text),
                Fueled = double.Parse(FueledTxb.Text),
                CarId = car.Id,
                Balance = _reportСalculator.GetBalance(car, double.Parse(FueledTxb.Text)),
                RestWay = _reportСalculator.GetRestWay(car, int.Parse(MileageTxb.Text))           // Math.Round((balance * 100) / car.Expenditure, 2)
            };
            if (report != null)
            {
                _dailyReportRepository.Create(report);

                var newCar = new Car()
                {
                    Mileage = car.Mileage + report.Mileage,
                    FuelLimit = report.Balance,
                    AvailableMileageLimit = car.AvailableMileageLimit - report.Mileage
                };

                _carRepository.UpdateAfterReport(newCar, car);
            }
            MileageTxb.Clear();
            FueledTxb.Clear();
        }
    }
}
