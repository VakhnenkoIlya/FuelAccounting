using Microsoft.EntityFrameworkCore;
using FuelAccounting;
using FuelAccounting.Services;
using System.Drawing;
using FuelAccounting.Model;

namespace FuelControl
{
    public partial class ManagerForm : Form
    {
        private CarsRepositoryService _carRepository;
        private DailyReportRepositoryService _dailyReportRepository;
        private CarCalculator _carCalculator;
        
        public ManagerForm()
        {
            InitializeComponent();
            _carRepository = new CarsRepositoryService();
            _dailyReportRepository = new DailyReportRepositoryService();    
            _carCalculator= new CarCalculator();    
            UpdateData();
            UpdateData();

        }

        private void UpdateData()
        {
            AutoTable.AutoGenerateColumns = false;
            List<Car> listCars = _carRepository.GetAll();
            AutoTable.DataSource = listCars;
           
            
            AutoTable.Columns["ModelCol"].DataPropertyName = "Model";
            AutoTable.Columns["ModelCol"].DataPropertyName = "Model";
            AutoTable.Columns["plankNumCol"].DataPropertyName = "NumberPlank";
            AutoTable.Columns["mileageAllCol"].DataPropertyName = "Mileage";
            AutoTable.Columns["limitCol"].DataPropertyName = "FuelLimit"; 
            AutoTable.Columns["typeFuelCol"].DataPropertyName = "FuelType";
            AutoTable.Columns["serviceIntervalCol"].DataPropertyName = "ServiceInterval";
            AutoTable.Columns["expenditureCol"].DataPropertyName = "Expenditure";
            AutoTable.Columns["availableMileageLimitCol"].DataPropertyName = "AvailableMileageLimit";
            //AutoTable.Columns["leftToServiceCol"].DataPropertyName = "LeftToService";
            //AutoTable.Columns["plannedServiceCol"].DataPropertyName = "PlannedService";
           
            for (int i = 0; i < listCars.Count; i++)
            {
                AutoTable[6, i].Value = _carCalculator.GetPlannedService(listCars[i]);
                AutoTable[7, i].Value = _carCalculator.GetLeftToService(listCars[i]);
               // AutoTable[8, i].Value = _carCalculator.GetAvailableMileageLimit(listCars[i]);  
            }
            AutoTable.Update();
        } 

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddAutoForm addAuto = new(_carCalculator);  
            addAuto.ShowDialog();
            _carRepository.Create(addAuto.car);
            UpdateData();
        }

        private void AddReportBtn_Click(object sender, EventArgs e)
        {
            AddReportForm report = new AddReportForm(AutoTable, _carRepository, _dailyReportRepository);
            report.ShowDialog();
            UpdateData();
        }

        private void ShowReport_Click(object sender, EventArgs e)
        {
            DailyReportForm form = new(AutoTable, _dailyReportRepository);
            form.ShowDialog();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteAutoForm deleteAuto = new(AutoTable);
            deleteAuto.ShowDialog();
            if(deleteAuto.car == null) return;
            _carRepository.Delete(deleteAuto.car);
            UpdateData ();
        }

        private void SetExpenditureBtn_Click(object sender, EventArgs e)
        {
            SetParameterForm form = new("Сезонное изменение расхода", "Расход", _carRepository, AutoTable);
            form.ShowDialog();
            UpdateData();   
        }

        private void UpdateLimit_Click(object sender, EventArgs e)
        {
            SetParameterForm form = new("Обновление лимита", "Лимит топлива", _carRepository, AutoTable);      
            form.ShowDialog();
            UpdateData();
        }

        private void UpdateService_Click(object sender, EventArgs e)
        {
            SetParameterForm form = new("Отметка о проведенном ТО", "Пробег при ТО ", _carRepository, AutoTable);
            form.ShowDialog();
            UpdateData();
        }
    }
}