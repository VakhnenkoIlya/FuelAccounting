using FuelAccounting;
using FuelAccounting.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelControl
{
    public partial class AddAutoForm : Form
    {
        public Car car;
        private CarCalculator _carCalculator;
        public AddAutoForm(CarCalculator carCalculator)
        {
            InitializeComponent();
            _carCalculator = carCalculator; 
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            car = new Car()
            {
                Model = ModelTxt.Text,
                NumberPlank= NumberPlankTxt.Text,
                Expenditure = int.Parse(ExpenditureTxt.Text),
                Mileage = int.Parse(MileageTxt.Text),
                FuelLimit = int.Parse(LimitTxt.Text),
                ServiceInterval = int.Parse(ServiceTxt.Text),
                FuelType = TypeFuelTxt.Text,
                LastService = int.Parse(LastMileageTxb.Text),
                AvailableMileageLimit =_carCalculator.GetAvailableMileageLimit(int.Parse(LimitTxt.Text), int.Parse(ExpenditureTxt.Text))
                //LeftToService = int.Parse(LastMileageTxb.Text) + int.Parse(ServiceTxt.Text) - int.Parse(MileageTxt.Text),
                //PlannedService = int.Parse(LastMileageTxb.Text) + int.Parse(ServiceTxt.Text)
            };
            if (car != null)
                Close();
            else MessageBox.Show("Автомобиль не добавлен");
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
