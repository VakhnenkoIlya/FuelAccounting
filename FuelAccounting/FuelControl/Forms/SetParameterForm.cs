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
using System.Windows.Forms;

namespace FuelControl
{
    public partial class SetParameterForm : Form
    {
        CarsRepositoryService _carsRepository;
        public SetParameterForm(string text, string parameter, CarsRepositoryService carsRepository, DataGridView autoTable)
        {
            InitializeComponent();
            Text= text;
            label1.Text= parameter;
            _carsRepository= carsRepository;
            AutoCmb.DataSource = autoTable.DataSource;
            AutoCmb.DisplayMember = "Model";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ParameterTxt.Text))
            {
                label3.Visible = true;
                return;
            }
            label3.Visible= false;
            if (label1.Text == "Расход")
            {
               _carsRepository.UpdateExpenditure((Car)AutoCmb.SelectedItem, int.Parse(ParameterTxt.Text));
            }
            else if(label1.Text == "Лимит топлива")
            {
                _carsRepository.UpdateLimit((Car)AutoCmb.SelectedItem, int.Parse(ParameterTxt.Text));
            }
            else
            {
                _carsRepository.UpdateLastService((Car)AutoCmb.SelectedItem, int.Parse(ParameterTxt.Text));
            }
            Close();    
        }
    }
}
